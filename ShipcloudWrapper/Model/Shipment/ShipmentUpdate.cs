using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipcloudWrapper.Model.Shipment
{
    public class ShipmentUpdate
    {

        public Carrier Carrier { get; set; }
        public Address.Address To { get; set; }
        public Package.Package Package { get; set; }
        public Service Service { get; set; }
        public string RefernceNumber { get; set; }
        public string NotificationEmail { get; set; }
        public bool CreateShippingLabel { get; set; }
    }
}
