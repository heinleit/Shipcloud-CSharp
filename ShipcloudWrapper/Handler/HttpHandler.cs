using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace ShipcloudWrapper.Handler
{
    public class HttpHandler
    {
        // Not an Singleton!
        public static HttpHandler Instance => new HttpHandler();

        // Fields
        private readonly RestClient _client;
        private readonly string _shipcloudUrl = "https://api.shipcloud.io/v1";

        public HttpHandler()
        {
            this._client = new RestClient(this._shipcloudUrl);
        }

        public void SetApiKey(string key)
        {
            this._client.Authenticator = new HttpBasicAuthenticator(key, "");
        }

        public ShipcloudResponse<TResult> FetchResponse<TRequest, TResult>(Method method, string path, IDictionary<string, string> parameters, TRequest obj0) where TResult : new()
        {
            var request = new RestRequest(path, method);
            foreach (var parameter in parameters)
            {
                request.AddUrlSegment(parameter.Key, parameter.Value);
            }

            request.AddJsonBody(obj0);

            var response = this._client.Execute<TResult>(request);

            return new ShipcloudResponse<TResult>
            {
                Result = response.Data,
                StatusCode = response.StatusCode
            };
        }

    }
}
