using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet --> haır kodlar. kare ve altında iki çizgi var 
    //kısaltmasını yazıp art arda tab tuşuna basınca gelir
    class Product //--> bu bir entity dir (varlık)
    {
        public int Id { get; set; } //Primary key
        public int CategoryId { get; set; } //referans anahtarı --> foreign key
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        // CRUD operasyonları --> Create Read Update Delete operations
        //Programlamada oluşturma, okuma, güncelleme ve silme,
        //veri depolamada kullanılan dört temel fonksiyondur
        //

        //otomasyon projeleri genellikle veritabanı programlamadır


    }
}
