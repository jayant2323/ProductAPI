
using System.Xml.Linq;

namespace BARTENDER_JOE
{
    public class GetProduct : IGetProduct
    {

        public Product GetValidProduct(string productId)
        {
            //Currently loading products from xml as xl can be updated in future. 
            var doc = XDocument.Load("Product/ProductList.xml");
            Product product = new Product();
            product.IsValid = false;
            foreach (var prod in doc.Descendants("Product"))
            {
                var _productId = prod.Element("Id")?.Value ?? "0";
                if (_productId == productId)
                {
                    product.Id = _productId;
                    product.IsValid = true;
                    product.Name = prod.Element("Name")?.Value ?? "";
                    product.State = prod.Element("State")?.Value ?? "";
                    product.Output = prod.Element("Output")?.Value ?? "";
                }
            }
            return product;
        }
    }
}
