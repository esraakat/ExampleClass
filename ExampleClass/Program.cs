using System;

namespace ExampleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productId = 111;
            product1.productName = "Apple";
            product1.productExplanation = "Amasya Apple";
            product1.productPrice = 10.75;
            product1.productNum = 10;

            Product product2 = new Product();
            product2.productId = 222;
            product2.productName = "Watermelon";
            product2.productExplanation = "Diyarbakır Watermelon";
            product2.productPrice = 80.99;
            product2.productNum = 20;

            Product product3 = new Product();
            product3.productId = 333;
            product3.productName = "Potato";
            product3.productExplanation = "Afyonkarahisar Potato";
            product3.productPrice = 15.55;
            product3.productNum = 30;

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.productId + ": " + product.productName +
                    ": " + product.productExplanation + ": " + product.productPrice);

                //instance - class örneği oluşturma
                SepetManager sepetManager = new SepetManager();
                sepetManager.Ekle(product);
                Console.WriteLine("---------------------\n");
            }


        }
    }
}
//methodlar tekrar tekrar kullanılabilirliği sağlar.
//encapsulation - kapsülleme
//Class içinde birden fazla method olabilir.
//Do not repeat yourself - DRY - Clean Code(Temiz kod yazma ) - Best Practice (Doğru uygulama teknikleri)