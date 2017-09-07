using System.Linq;
using ProductInterface;
using System.Net;

namespace DALWebApi
{
    public class Product : IProduct
    {
        public Entities.Product GetProductByID(int ID)
        {
            Entities.Product Product = null;
            var JSON = new WebClient().DownloadString("https://ticapacitacion.com/webapi/northwind/products");
            var Products = Newtonsoft.Json.JsonConvert.DeserializeObject<Entities.Product[]>(JSON);
            Product = Products.Where(x => x.ProductID == ID).FirstOrDefault();
            return Product;
        }
    }


}
