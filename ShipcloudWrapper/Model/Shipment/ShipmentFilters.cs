using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipcloudWrapper.Model.Shipment
{
    public class ShipmentFilters
    {
        public Carrier Carrier { get; set; }
        public Service Service { get; set; }
        public string ReferenceNumber { get; set; }
        public string CarrierTrackingNo { get; set; }
        public string TrackingStatus { get; set; }
        public int Page { get; set; }
        public int PerPage { get; set; }
    }
}
