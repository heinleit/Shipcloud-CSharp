using System.Collections.Generic;

namespace ShipcloudWrapper.Model.Shipment
{
    public class AdditionalService
    {
        public string Name { get; set; }
        public Dictionary<string, string> Properties { get; set; }
    }
}