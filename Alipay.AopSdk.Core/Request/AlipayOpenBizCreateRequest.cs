using System;
using System.Collections.Generic;
using Alipay.AopSdk.Core.Domain;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.Core.Request
{
    /// <summary>
    /// AOP API: alipay.open.biz.create
    /// </summary>
    public class AlipayOpenBizCreateRequest : IAopRequest<AlipayOpenBizCreateResponse>
    {
        /// <summary>
        /// 2121
        /// </summary>
        public Gavintest A { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        public string B { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        public GavintestNewLeveaOne De { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        public string Stringbuff { get; set; }

        #region IAopRequest Members
		private bool  needEncrypt=false;
        private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;
        private string returnUrl;
		private AopObject bizModel;

		public void SetNeedEncrypt(bool needEncrypt){
             this.needEncrypt=needEncrypt;
        }

        public bool GetNeedEncrypt(){

            return this.needEncrypt;
        }

		public void SetNotifyUrl(string notifyUrl){
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl(){
            return this.notifyUrl;
        }

        public void SetReturnUrl(string returnUrl){
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl(){
            return this.returnUrl;
        }

        public void SetTerminalType(String terminalType){
			this.terminalType=terminalType;
		}

    	public string GetTerminalType(){
    		return this.terminalType;
    	}

    	public void SetTerminalInfo(String terminalInfo){
    		this.terminalInfo=terminalInfo;
    	}

    	public string GetTerminalInfo(){
    		return this.terminalInfo;
    	}

        public void SetProdCode(String prodCode){
            this.prodCode=prodCode;
        }

        public string GetProdCode(){
            return this.prodCode;
        }

        public string GetApiName()
        {
            return "alipay.open.biz.create";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("a", this.A);
            parameters.Add("b", this.B);
            parameters.Add("de", this.De);
            parameters.Add("stringbuff", this.Stringbuff);
            return parameters;
        }

		public AopObject GetBizModel()
        {
            return this.bizModel;
        }

        public void SetBizModel(AopObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion
    }
}
