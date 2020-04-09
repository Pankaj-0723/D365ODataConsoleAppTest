using Newtonsoft.Json;
using ODataUtility.Microsoft.Dynamics.DataEntities;
using System;
using System.Linq;

namespace ODataConsoleApp
{
    class SimpleCRUDExamples
    {
        public static void SimpleCRUD(Resources d365)
        {
            string assetMajorTypeId = "10";
            string company = "USMF";

            // Create
           /* d365.AddToAssetMajorTypes(new AssetMajorType
            {
                DataAreaId = company,
                MajorTypeId = assetMajorTypeId,
                Description = "Description of Test01"
            });

            // Uncomment below line when you want to save the data.
            d365.SaveChanges();*/

            // Read

            //var assetMajorType = d365.AssetMajorTypes.Where(x => x.DataAreaId == company && x.MajorTypeId == assetMajorTypeId).First();
            // Below line will read Customer data from the service.
            var customerData = d365.Customers.Where(x => x.DataAreaId == "usmf" && x.CustomerAccount == "DE-001").First();// && x.PartyNumber == "000000838" && x.CustomerGroupId== "90").First();
            Console.WriteLine(JsonConvert.SerializeObject(customerData));
            // Below line will read CustomerGroup data from the service.
            var assetMajorType = d365.CustomerGroups.Where(x => x.DataAreaId == company && x.CustomerGroupId == assetMajorTypeId).First();
            Console.WriteLine(JsonConvert.SerializeObject(assetMajorType));
            //Below line will read data of SalesInvoiceHeader from the service.
            var salesInvoiceHeaderData = d365.SalesInvoiceHeaders.Where(x => x.DataAreaId == "usmf" && x.InvoiceNumber == "CIV-000001").First();
            Console.WriteLine(JsonConvert.SerializeObject(salesInvoiceHeaderData));
            // Below line will read data of SalesInvoiceLine from the service
            var salesInvoiceLineData = d365.SalesInvoiceLines.Where(x => x.DataAreaId == "usmf" && x.InvoiceNumber == "CIV-000001").First();
            Console.WriteLine(JsonConvert.SerializeObject(salesInvoiceLineData));

            Console.WriteLine("Asset Major type of ID {0} successfully created and read.", assetMajorType.Description);

            // Update
            /*assetMajorType.Description = "Updated description";
            d365.UpdateObject(assetMajorType);
            d365.SaveChanges();

            var assetMajorTypeAfterUpdate = d365.AssetMajorTypes.Where(x => x.DataAreaId == company && x.MajorTypeId == assetMajorTypeId).First();
            Console.WriteLine(JsonConvert.SerializeObject(assetMajorTypeAfterUpdate));

            Console.WriteLine("Asset Major type of ID {0} successfully updated.", assetMajorTypeAfterUpdate.MajorTypeId);*/

            // Delete

            /*d365.DeleteObject(assetMajorTypeAfterUpdate);
            d365.SaveChanges();

            var assetMajorTypeAfterDelete = d365.AssetMajorTypes.Where(x => x.DataAreaId == company && x.MajorTypeId == assetMajorTypeId);

            Console.WriteLine("Records found = {0}", assetMajorTypeAfterDelete.Count());
            Console.WriteLine("Asset Major type of ID {0} successfully deleted.", assetMajorTypeAfterUpdate.MajorTypeId);*/
        }
    }
}
