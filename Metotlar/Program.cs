namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyat = 15;
            string aciklama = "Amasya Elması";

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır ka rpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle();
            sepetManager.Ekle();
            sepetManager.Ekle();
            sepetManager.Ekle();
            sepetManager.Ekle();





        }
    }
}
