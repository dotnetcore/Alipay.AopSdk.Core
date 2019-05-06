using System;
using System.Collections.Concurrent;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Alipay.AopSdk.Core.Util
{
    internal class WebUtilsHttpConnectionPool
    {
        private readonly ConcurrentStack<HttpClient> _clients = new ConcurrentStack<HttpClient>();
        private string _url = string.Empty;
        private int _size = 1;
        private readonly object _lockObject = new object();
        private double _timeout  = 60000;

        /// <summary>
        /// 初始化 HttpClient 池
        /// </summary>
        /// <param name="url">目标域名，不带路径 比如 http://www.baidu.com </param>
        /// <param name="num">池里Client数量</param>
        public WebUtilsHttpConnectionPool(string url, int num)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException(nameof(url));
            }

            if (num <= 0)
            {
                throw new ArgumentException(nameof(num));
            }
            _clients.Clear();
            _url = url;
            _size = num;
        
        }

        public HttpClient GetClient()
        {
            if (_clients.TryPop(out var client))
            {
                return client;
            }
            else
            {
                var newClient = new HttpClient()
                    { BaseAddress = new Uri(_url), Timeout = TimeSpan.FromMilliseconds(_timeout) };
                newClient.DefaultRequestHeaders.Add("User-Agent", "Aop4Net");
                newClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
                return newClient;
            }
        }

        public void ReturnClient(HttpClient client)
        {
            lock (_lockObject)
            {
                if (_clients.Count >= _size)
                {
                    client.Dispose();
                }
                else
                {
                    _clients.Push(client);
                }
            }
        }
    }
}