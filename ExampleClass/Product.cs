using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleClass
{
    class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string productExplanation { get; set; }
        public double productPrice { get; set; }
        public int productNum { get; set; }

    }
}
//classların burdaki kullanılma nedeni özellik tutmaktır.
//Product classında projede kullanacağımız propertileri tanımladık, yani model oluşturduk.