using System.Net;

namespace ShipcloudWrapper.Handler
{
    public class ShipcloudResponse<TResult>
    {
        public TResult Result { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}