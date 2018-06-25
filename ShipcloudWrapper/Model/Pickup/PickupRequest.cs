using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipcloudWrapper.Model.Shipment;

namespace ShipcloudWrapper.Model.Pickup
{
    public class PickupRequest : Pickup
    {
        public Carrier Carrier { get; set; }
    }
}
