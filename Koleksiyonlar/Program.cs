using System;
using System.Collections.Generic;
namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //temel3
            string[] isimler = new string[] { "Ayşe", "Kübra", "Elif", "Zeynep" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);
            //sisstem patlar
          */


            /*
            //temel4
            string[] isimler = new string[] { "Ayşe", "Kübra", "Elif", "Zeynep" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            //buraya kadar normal yazacak her elemannı
            isimler = new string[5];
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);//bunu da yazar ancak
            //3 satır üstte new yazarak dizi için yeni bellek alanı tayin ettik
            //bu durumda ilk 4 eleman null ("") 5. eleman İlker olacak
            Console.WriteLine(isimler[0]);//output:
            //burada ilker'i yazar
            */



            //yukarıdaki problemlerden dolayı C# koleksiyonlar yapısını ouşturmuştur
            //List<string> isimler2 = new List<string>();
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            //? List yapısı .NET 2.0 ile birlikte geldi
            //referans tipler hem stack i hem de heap i kullanır
            //değer tipler sadece stack i kullanır
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            //burada 0. elemanı da okur
            //output:
            /*Engin
             * Kerem
             * Murat
             * Halil 
             */

            //className<T> olduğu yapıda < ve > generic olduğunu gösterir
        }
    }
}
