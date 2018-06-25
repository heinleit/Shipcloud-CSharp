using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipcloudWrapper.Model.Package;

namespace ShipcloudWrapper.Model.Shipment
{
    public class ShipmentResponse : Shipment
    {
        public string CarrierTrackingNo { get; set; }
        public DateTime CreateAt { get; set; }
        public string Id { get; set; }
        public string LabelUrl { get; set; }
        public PackageResponse Packages { get; set; }
        public double Price { get; set; }
        public string ShipperNotificationEmail { get; set; }
        public string TrackingUrl { get; set; }
    }
}
