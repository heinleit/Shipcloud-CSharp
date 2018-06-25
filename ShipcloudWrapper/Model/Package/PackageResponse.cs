using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipcloudWrapper.Model.Package
{
    public class PackageResponse : Package
    {
        public string Id { get; set; }
        public TrackingEvent[] TrackingEvents { get; set; }
    }
}
