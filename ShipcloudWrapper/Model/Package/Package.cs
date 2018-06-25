using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipcloudWrapper.Model.Package
{
    public class Package
    {
        public float Width { get; set; }
        public float Length { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public PackageDeclaredValue DeclaredValue { get; set; }
        public string Description { get; set; }
        public PackageType Type { get; set; }

    }
}
