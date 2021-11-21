using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //eğer class isimlendirmede Manager ya da Server gibi kelimeler var ise;
    //orada onunla ilgili operasyonlar vardır
    //ekleme silme oluşturma güncelleme filtreleme vs...
    class ProductManager
    {
        //encapsülation
        public void Add(Product product)
        {
            /*
            //temel
            //Console.WriteLine("eklendi: " + product.ProductName);*/

            /*
            //temel1
            product.ProductName = "Kamera";
            */

            Console.WriteLine(product.ProductName + "eklendi");

        }


        /*
        //temel1
        public void BiseyYap(int sayi)
        {
            sayi = 99;
        }*/

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi");
        }


        //temel2
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
