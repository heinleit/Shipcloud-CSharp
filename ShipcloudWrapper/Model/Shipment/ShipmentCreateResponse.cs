using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipcloudWrapper.Model.Shipment
{
    public class ShipmentCreateResponse
    {
        public string Id { get; set; }
        public string CarrierTrackingNo { get; set; }
        public string TrackingUrl { get; set; }
        public string LabelUrl { get; set; }
        public double Price { get; set; }
    }
}
