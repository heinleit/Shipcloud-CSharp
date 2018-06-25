using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipcloudWrapper.Model.Address;
using ShipcloudWrapper.Model.Package;
using ShipcloudWrapper.Model.Shipment;
using ShipcloudWrapper.Repository;

namespace ShipcloudTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new ShipcloudRepository();
            repository.HttpHandler.SetApiKey("##########################");
            
            var response = repository.Shipment.CreateShipment(new ShipmentRequest
            {
                To = new Address
                {
                    Company = "Heinle IT-Systeme",
                    FirstName = "Hendrik",
                    LastName = "Heinle",
                    Street = "Burbecker Str.",
                    StreetNo = "45",
                    City = "Gevelsberg",
                    ZipCode = "58285",
                    Country = "DE"
                },
                Package = new Package
                {
                    Weight = 1,
                    Length = 30,
                    Height = 10,
                    Width = 20,
                    Type = PackageType.Parcel
                },
                Carrier = Carrier.Dhl,
                Service = Service.Standard,
                RefernceNumber = "Ababa123",
                NotificationEmail = "info@hendrik-heinle.de",
                CreateShippingLabel = true
            });

            Console.Write(response.Result?.Id);
            
            Console.ReadKey();
        }
    }
}
