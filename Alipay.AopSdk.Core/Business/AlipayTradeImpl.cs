using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Alipay.AopSdk.Core;
using Alipay.AopSdk.Core.Request;
using Alipay.AopSdk.Core.Response;
using Alipay.AopSdk.Core.Util;
using Alipay.AopSdk.F2FPay.Domain;
using Alipay.AopSdk.F2FPay.Model;


namespace Alipay.AopSdk.F2FPay.Business
{
    /// <summary>
    /// AlipayTradePayImpl 的摘要说明
    /// </summary>
    public class AlipayTradeImpl : IAlipayTradeService
    {

  

        IAopClient client = null; 

        public AlipayTradeImpl(string serverUrl, string appId, string merchant_private_key, string format, string version,
     string sign_type, string alipay_public_key, string charset)
        {
            client = new DefaultAopClient(serverUrl, appId, merchant_private_key, format, version,
           sign_type, alipay_public_key, charset);

        }


        #region 接口方法
        public AlipayF2FPayResult TradePay(AlipayTradePayContentBuilder builder)
        {               
            AlipayF2FPayResult payResult = new AlipayF2FPayResult();
            try
            {

                AlipayTradePayRequest payRequest = new AlipayTradePayRequest();
                payRequest.BizContent = builder.BuildJson();
                AlipayTradePayResponse payResponse = client.Execute(payRequest);
                
                //payRequest.SetBizModel("");

                if (payResponse != null)
                {

                    switch (payResponse.Code)
                    {
                        case ResultCode.SUCCESS:
                            break;

                        //返回支付处理中，需要进行轮询
                        case ResultCode.INRROCESS:

                            AlipayTradeQueryResponse queryResponse = LoopQuery(builder.out_trade_no, 10, 3000);   //用订单号trade_no进行轮询也是可以的。
                            //轮询结束后还是支付处理中，需要调撤销接口
                            if (queryResponse != null)
                            {
                                if (queryResponse.TradeStatus == "WAIT_BUYER_PAY")
                                {
                                    CancelAndRetry(builder.out_trade_no);
                                    payResponse.Code = ResultCode.FAIL;
                                }
                                payResponse = toTradePayResponse(queryResponse);
                            }
                            break;

                        //明确返回业务失败
                        case ResultCode.FAIL:
                            break;

                        //返回系统异常，需要调用一次查询接口，没有返回支付成功的话调用撤销接口撤销交易
                        case ResultCode.ERROR:

                            AlipayTradeQueryResponse queryResponse2 = sendTradeQuery(builder.out_trade_no);

                            if (queryResponse2 != null)
                            {
                                if (queryResponse2.TradeStatus == TradeStatus.WAIT_BUYER_PAY)
                                {
                                    AlipayTradeCancelResponse cancelResponse = CancelAndRetry(builder.out_trade_no);
                                    payResponse.Code = ResultCode.FAIL;
                                }

                                payResponse = toTradePayResponse(queryResponse2);

                            }
                            break;

                        default:
                            payResult.response = payResponse;
                            break;
                    }
                    payResult.response = payResponse;
                    return payResult;
                }
                else
                {
                    AlipayTradeQueryResponse queryResponse3 = sendTradeQuery(builder.out_trade_no);
                    if (queryResponse3 != null)
                    {
                        if (queryResponse3.TradeStatus == TradeStatus.WAIT_BUYER_PAY)
                        {
                            AlipayTradeCancelResponse cancelResponse = CancelAndRetry(builder.out_trade_no);
                            payResponse.Code = ResultCode.FAIL;
                        }
                        payResponse = toTradePayResponse(queryResponse3);
                    }
                    payResult.response = payResponse;
                    return payResult;
                }
                //return payResult;
            }
            catch(Exception e)
            {

                AlipayTradePayResponse payResponse = new AlipayTradePayResponse();
                payResponse.Code = ResultCode.FAIL;
                payResponse.Body = e.Message;
                payResult.response = payResponse;
                return payResult;
            }
        }

        public AlipayF2FQueryResult TradeQuery(string outTradeNo)
        {
            return AsyncHelper.RunSync(async () => await TradeQueryAsync(outTradeNo));
        }

        public async Task<AlipayF2FQueryResult> TradeQueryAsync(string outTradeNo)
        {
            AlipayF2FQueryResult result = new AlipayF2FQueryResult();
            try
            {

                AlipayTradeQueryContentBuilder build = new AlipayTradeQueryContentBuilder();
                build.out_trade_no = outTradeNo;
                AlipayTradeQueryRequest payRequest = new AlipayTradeQueryRequest();
                payRequest.BizContent = build.BuildJson();
                result.response = await client.ExecuteAsync(payRequest);
                return result;
            }
            catch
            {
                result.response = null;
                return result;
            }
        }


        public AlipayF2FRefundResult TradeRefund(AlipayTradeRefundContentBuilder builder)
        {
            return AsyncHelper.RunSync(async () => await TradeRefundAsync(builder));
        }

        public async Task<AlipayF2FRefundResult> TradeRefundAsync(AlipayTradeRefundContentBuilder builder)
        {
            var refundResult = new AlipayF2FRefundResult();
            try
            {

                AlipayTradeRefundRequest refundRequest = new AlipayTradeRefundRequest();
                refundRequest.BizContent = builder.BuildJson();
                refundResult.response = await client.ExecuteAsync(refundRequest);
                return refundResult;
            }
            catch
            {
                refundResult.response = null;
                return refundResult;
            }
        }

        public AlipayF2FPrecreateResult TradePrecreate(AlipayTradePrecreateContentBuilder builder)
        {
            return AsyncHelper.RunSync(async () => await TradePrecreateAsync(builder));
        }

        public async Task<AlipayF2FPrecreateResult> TradePrecreateAsync(AlipayTradePrecreateContentBuilder builder)
        {
            AlipayF2FPrecreateResult payResult = new AlipayF2FPrecreateResult();
            try
            {

                AlipayTradePrecreateRequest payRequest = new AlipayTradePrecreateRequest();
                payRequest.BizContent = builder.BuildJson();


                payResult.response = await client.ExecuteAsync(payRequest);
                return payResult;
            }
            catch
            {
                payResult.response = null;
                return payResult;
            }
        }

        public AlipayF2FPrecreateResult TradePrecreate(AlipayTradePrecreateContentBuilder builder, string notify_url)
        {
            return AsyncHelper.RunSync(async () => await TradePrecreateAsync(builder, notify_url));
        }

        public async Task<AlipayF2FPrecreateResult> TradePrecreateAsync(AlipayTradePrecreateContentBuilder builder, string notify_url)
        {
            AlipayF2FPrecreateResult payResult = new AlipayF2FPrecreateResult();
            try
            {
                AlipayTradePrecreateRequest payRequest = new AlipayTradePrecreateRequest();
                payRequest.BizContent = builder.BuildJson();
                payRequest.SetNotifyUrl(notify_url);
                payResult.response = await client.ExecuteAsync(payRequest);
                return payResult;

            }
            catch
            {
                payResult.response = null;
                return payResult;
            }
        }

        #endregion


        #region 内部方法
        private AlipayTradeCancelResponse tradeCancel(string outTradeNo)
        {
            try
            {
                AlipayTradeCancelRequest request = new AlipayTradeCancelRequest();
                StringBuilder sb2 = new StringBuilder();
                sb2.Append("{\"out_trade_no\":\"" + outTradeNo + "\"}");
                request.BizContent = sb2.ToString();
                AlipayTradeCancelResponse response = client.Execute(request);
                return response;
            }
            catch
            {
                return null;
            }

        }

        private AlipayTradePayResponse toTradePayResponse(AlipayTradeQueryResponse queryResponse)
        {
            if (queryResponse == null || queryResponse.Code != ResultCode.SUCCESS)
                return null;
            AlipayTradePayResponse payResponse = new AlipayTradePayResponse();

            if (queryResponse.TradeStatus == TradeStatus.WAIT_BUYER_PAY)
            {
                payResponse.Code = ResultCode.INRROCESS;
            }
            if (queryResponse.TradeStatus == TradeStatus.TRADE_FINISHED
                || queryResponse.TradeStatus == TradeStatus.TRADE_SUCCESS)
            {
                payResponse.Code = ResultCode.SUCCESS;
            }
            if (queryResponse.TradeStatus == TradeStatus.TRADE_CLOSED)
            {
                payResponse.Code = ResultCode.FAIL;
            }

            payResponse.Msg = queryResponse.Msg;
            payResponse.SubCode = queryResponse.SubCode;
            payResponse.SubMsg = queryResponse.SubMsg;
            payResponse.Body = queryResponse.Body;
            payResponse.BuyerLogonId = queryResponse.BuyerLogonId;
            payResponse.FundBillList = queryResponse.FundBillList;
            payResponse.OpenId = queryResponse.OpenId;
            payResponse.OutTradeNo = queryResponse.OutTradeNo;
            payResponse.ReceiptAmount = queryResponse.ReceiptAmount;
            payResponse.TotalAmount = queryResponse.TotalAmount;
            payResponse.TradeNo = queryResponse.TradeNo;


            return payResponse;


        }


        private AlipayTradeQueryResponse sendTradeQuery(string outTradeNo)
        {
            try
            {
                AlipayTradeQueryContentBuilder build = new AlipayTradeQueryContentBuilder();
                build.out_trade_no = outTradeNo;
                AlipayTradeQueryRequest payRequest = new AlipayTradeQueryRequest();
                payRequest.BizContent = build.BuildJson();
                AlipayTradeQueryResponse payResponse = client.Execute(payRequest);
                return payResponse;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 1.返回支付处理中，轮询订单状态
        /// 2.本示例中轮询了6次，每次相隔5秒
        /// </summary>
        /// <param name="biz_content"></param>
        /// <returns></returns>
        private AlipayTradeQueryResponse LoopQuery(string out_trade_no, int count, int interval)
        {
            AlipayTradeQueryResponse queryResult = null;

            for (int i = 1; i <= count; i++)
            {
                Thread.Sleep(interval);
                AlipayTradeQueryResponse queryResponse = sendTradeQuery(out_trade_no);
                if (queryResponse != null && string.Compare(queryResponse.Code, ResultCode.SUCCESS, false) == 0)
                {
                    queryResult = queryResponse;
                    if (queryResponse.TradeStatus == "TRADE_FINISHED"
                        || queryResponse.TradeStatus == "TRADE_SUCCESS"
                        || queryResponse.TradeStatus == "TRADE_CLOSED")
                        return queryResponse;
                }
            }

            return queryResult;

        }

        /// <summary>
        /// 撤销订单
        /// </summary>
        /// <param name="out_trade_no"></param>
        /// <returns></returns>
        private AlipayTradeCancelResponse CancelAndRetry(string out_trade_no)
        {
            AlipayTradeCancelResponse cancelResponse = null;

            cancelResponse = tradeCancel(out_trade_no);

            //如果撤销失败，新开一个线程重试撤销，不影响主业务
            if (cancelResponse == null || (cancelResponse.Code == ResultCode.FAIL && cancelResponse.RetryFlag == "Y"))
            {
                ParameterizedThreadStart ParStart = new ParameterizedThreadStart(cancelThreadFunc);
                Thread myThread = new Thread(ParStart);
                object o = out_trade_no;
                myThread.Start(o);
            }
            return cancelResponse;
        }

        private void cancelThreadFunc(object o)
        {
            int RETRYCOUNT = 10;
            int INTERVAL = 10000;

            for (int i = 0; i < RETRYCOUNT; ++i)
            {

                Thread.Sleep(INTERVAL);
                AlipayTradeCancelRequest cancelRequest = new AlipayTradeCancelRequest();
                string outTradeNo = o.ToString();
                AlipayTradeCancelResponse cancelResponse = tradeCancel(outTradeNo);

                if (null != cancelResponse)
                {
                    if (cancelResponse.Code == ResultCode.FAIL)
                    {
                        if (cancelResponse.RetryFlag == "N")
                        {
                            break;
                        }
                    }
                    if ((cancelResponse.Code == ResultCode.SUCCESS))
                    {
                        break;
                    }
                }

                if (i == RETRYCOUNT - 1)
                {
                    /** ！！！！！！！注意！！！！！！！！
                    处理到最后一次，还是未撤销成功，需要在商户数据库中对此单最标记，人工介入处理*/
                }

            }
        }

        #endregion
    }
}