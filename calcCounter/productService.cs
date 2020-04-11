using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcCounter
{
    class productService
    {
        static List<Product> productInBase = new List<Product>();

        public void addProductToList(string name, double calories, double protein, double fat, double carbs)
        {
            Product product = new Product(name, calories, protein, fat, carbs);
            productInBase.Add(product);
        }



    }
}
