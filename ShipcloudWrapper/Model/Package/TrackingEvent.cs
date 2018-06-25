using System;

namespace ShipcloudWrapper.Model.Package
{
    public class TrackingEvent
    {
        public DateTime Timestamp { get; set; }
        public string Location { get; set; }
        public TrackingStatus Status { get; set; }
        public string Details { get; set; }
    }
}