using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ShipcloudWrapper.Handler;
using ShipcloudWrapper.Model.Shipment;

namespace ShipcloudWrapper.Repository
{
    public class ShipmentRepository
    {
        private readonly HttpHandler _httpHandler;

        internal ShipmentRepository(HttpHandler httpHandler)
        {
            this._httpHandler = httpHandler;
        }


        public ShipcloudResponse<ShipmentResponse> CreateShipment(ShipmentRequest req)
        {
            return this._httpHandler.FetchResponse<ShipmentRequest, ShipmentResponse>(Method.POST, "shipments",
                new Dictionary<string, string>(), req);
        }

//        public ShipcloudResponse<List<ShipmentResponse>> GetShipments(ShipmentFilters filters)
//        {
//            return this._httpHandler.FetchResponse<ShipmentFilters, List<ShipmentResponse>>(Method.GET, "shipments",
//                new Dictionary<string, string>(), filters);
//        }
    }
}
