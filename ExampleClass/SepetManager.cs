using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleClass
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Congratulations. The product was added: " + product.productName);
        }
    }
}
//naming convention - doğru yazma teknikleri
//Classların 2.kullanılma nedeni - method/fonksiyon tutmaktır.
//If there is () C#, it means a method is working.
//SepetManager classında methodlarımız/fonksiyonnlarımızı belirledik, yani yaptıracağımız işlemleri belirledik.