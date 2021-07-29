using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne
{

   class Bilet:IFiyat
    {
       public List<Bilet> Biletler = new List<Bilet>();
        List<Koltuk> Koltuklar = new List<Koltuk>();
       public string ad, soyad;
       public int tc,fiyat;
        List<Gosterim> Gosterimler = new List<Gosterim>();

        public Bilet(string ad,string soyad, int tc,int fiyat)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.tc = tc;
            this.fiyat = fiyat;
        }
        public override string ToString()
        {
            return "Ad: " + ad + "Soyad: " + soyad + "Tc: " + tc + "Fiyat: " + fiyat;
        } 
        public void Biletokut(List<Bilet>Bilet2)
        {
            foreach (Bilet x in Bilet2)
            {
                Console.WriteLine(x);

            }
        }
        public int Fiyat()
        {
            return fiyat;
        }
        public List<Bilet> bilgi(List<Bilet>Biletler)
        {
            int karar;
            Console.WriteLine("Bilgi Yazdirmak Icin 1 ,Okumak icin 2 Girin");
            karar =Convert.ToInt32(Console.ReadLine());
            if (karar == 1)
            {
                foreach (Bilet x in Biletler)
                {
                    Console.WriteLine(x);
                }
            }
            else
            {
                return Biletler;
            }
            return null;
             
        }
    }
}
