using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipcloudWrapper.Model.Package;

namespace ShipcloudWrapper.Model.Shipment
{
    public class ShipmentRequest : Shipment
    {
        public AdditionalService[] AdditionalServices { get; set; }
        public Pickup.Pickup Pickup { get; set; }
        public string Description { get; set; }
        public Label Label { get; set; }
        public bool CreateShippingLabel { get; set; }
        public Package.Package Package { get; set; }
    }
}
