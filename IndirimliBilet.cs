using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne
{
    class IndirimliBilet:Bilet,IIndirim
    {
        public int indirimmiktari1;
        public string kullanicikod1;
        string kod = "indirim123";
        public IndirimliBilet(string ad, string soyad, int tc, int fiyat,string kullanicikod1,int indirimmiktari1):base(ad,soyad,tc,fiyat)
        {
            this.indirimmiktari1 = indirimmiktari1;
            this.kullanicikod1 = kullanicikod1;
        }
        public int indirimmiktari()
        {
            int yenifiyat = fiyat - (fiyat * (indirimmiktari1 / 100));
            fiyat = yenifiyat;
            return yenifiyat;
            
        }
        public string indirimkodu()
        {
            if(kod == "indirim123")
            {
                return "kod gecerli";
            }
            else
            {
                return "gecersiz kod";
            }
        }
       

    }
}
