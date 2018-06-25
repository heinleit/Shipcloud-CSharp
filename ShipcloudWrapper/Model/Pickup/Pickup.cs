using ShipcloudWrapper.Model.Shipment;

namespace ShipcloudWrapper.Model.Pickup
{
    public class Pickup {
        public PickupTime PickupTime { get; set; }
        public Address.AddressResponse PickupAddress { get; set; }
    }
}