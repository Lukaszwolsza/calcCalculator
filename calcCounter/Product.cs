using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcCounter
{
    class Product
    {
        public string productName { get; private set; }
        public double productCalories { get; private set; }
        public double productProtein { get; private set; }
        public double productFat { get; private set; }
        public double productCarbs { get; private set; }

        public Product(string name, double calories, double protein, double fat, double carbs)
        {
            setProductName(name);
            setProductCalories(calories);
            setProductProtein(protein);
            setProductFat(fat);
            setProductCarbs(carbs);
        }

        Product() { }

        public void setProductName(string name)
        {
            this.productName = name;
        }
        public void setProductCalories(double calories)
        {
            this.productCalories = calories;
        }
        public void setProductProtein(double protein)
        {
            this.productProtein = protein;
        }
        public void setProductFat(double fat)
        {
            this.productFat= fat;
        }
        public void setProductCarbs(double carbs)
        {
            this.productCarbs = carbs;
        }

    }
}
