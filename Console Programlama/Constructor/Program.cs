using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Calisan 1******");
            Calisan calisan1 = new Calisan("Ayşe","Kara",23465730,"İnsan Kaynakları");
            calisan1.CaslisanBilgileri();

            Console.WriteLine("******Calisan 2******");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 23425636;
            calisan2.Departman = "Satın Alma ";
            calisan2.CaslisanBilgileri();

            Console.WriteLine("******Calisan 3******");
            Calisan calisan3 = new Calisan("Fatma", "Kara");
            calisan3.CaslisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            
        }

        public Calisan() { }
        public void CaslisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }
    }
}
