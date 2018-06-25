using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipcloudWrapper.Model.Shipment
{
    public class Shipment
    {
        public Carrier Carrier { get; set; }
        public Address.Address To { get; set; }
        public Address.Address From { get; set; }
        public Service Service { get; set; }
        public string RefernceNumber { get; set; }
        public string NotificationEmail { get; set; }
    }
}
