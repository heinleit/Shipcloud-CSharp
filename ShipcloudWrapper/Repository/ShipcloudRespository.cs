using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipcloudWrapper.Handler;

namespace ShipcloudWrapper.Repository
{
    public class ShipcloudRepository
    {
        private HttpHandler _httpHandler;
        private ShipmentRepository _shipmentRepository;


        public HttpHandler HttpHandler => this._httpHandler ?? (this._httpHandler = HttpHandler.Instance);
        
        public ShipmentRepository Shipment => this._shipmentRepository ??
                                              (_shipmentRepository = new ShipmentRepository(this.HttpHandler));

    }
}
