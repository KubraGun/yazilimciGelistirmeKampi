using System;

namespace OOP1
{
    // CTRL + ALT + L --> Solution Explorer
    class Program
    {
        static void Main(string[] args)
        { //PascalCase   camelCase         
            Product      product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //oluşturduğumuz nesne olan ürün aşağıdaki şekilde de tanımlanabilir
            Product product = new Product {
                Id = 2,
                CategoryId = 5,
                ProductName = "Kalem",
                UnitPrice = 35,
                UnitsInStock = 5
                //tanımlama sırası farklı olabilir. Hiç bir şey değişmez
            };
          //-------------STACK-----------    --------HEAP--------
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


            /*
            //temel1
            int sayi = 100;
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi);
            //ProductManager da ismini değiştirelim:
            productManager.Add(product1);
            Console.WriteLine( sayi);
            Console.WriteLine(product1.ProductName);
            //
            //output
            //100
            //Kamera
            //
            //int, bool, double ... değer tip 
            //diziler, class, abstract class, interface... referans tip
            */


            /*
            //temel2
            productManager.Topla2(3, 6);//burada elimizde herhangi bir veri yok. toplama sonucunu kullanamayız
            int toplamaSonucu = productManager.Topla(3, 6); // buradaki veriyi kullanabiliriz
            Console.WriteLine(toplamaSonucu * 2);
            */
        }
    }
}
