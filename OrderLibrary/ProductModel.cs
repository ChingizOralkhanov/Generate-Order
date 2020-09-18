using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Amount { get; set; }
        public ProductModel()
        {

        }
        public ProductModel(string productName, int amount )
        {
            ProductName = productName;
            Amount = amount;
            ProductCode = GetAllProductCodes(productName);
        }
        public string GetAllProductCodes(string name)
        {
            var code = "";
            switch (name)
            {
                case "AllergyScreen Panel 1":
                    code = "A2142";
                    break;
                case "AllergyScreen Panel 2":
                    code = "A2242";
                    break;

                case "AllergyScreen Panel 3":
                    code = "A2342";
                    break;

                case "AllergyScreen Panel 4":
                    code = "A2442";
                    break;
                case "Qline Panel 1":
                    code = "A4442";
                    break;

                case "Qline Panel 2":
                    code = "A4542";
                    break;

                case "Qline Panel 3":
                    code = "A4642";
                    break;
                case "Qline Panel 4":
                    code = "A4742";
                    break;
                default:
                    break;
            }
            return code;
        }
    }
}
