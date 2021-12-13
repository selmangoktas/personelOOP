using System;

namespace personelOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            KadroluPersonel k = new KadroluPersonel {
                sicilNo = "20000",
                ad = "selman",
                soyad = "Göktaş",
                izin = 16,
                rapor=2,
                ucret=10000,
                KadroUnvani="Endüstri Mühendisi"

            };

            Console.WriteLine(k.AdSoyadGetir());
            Console.WriteLine(k.AylikGoruntule());
            Console.ReadLine();
            
        }
    }
}
