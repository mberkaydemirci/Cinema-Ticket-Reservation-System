using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne
{
    class Gosterim
    {
       public List<Koltuk> Koltuklar = new List<Koltuk>();
        string filmadi;
        int seans, tarih, salonno;
        public Gosterim(string filmadi,int seans,int tarih,int salonno)
        {
            this.filmadi = filmadi;
            this.seans = seans;
            this.tarih = tarih;
            this.salonno = salonno;
        }
        public Gosterim(int salonno)
        {
            this.salonno = salonno;
        }
        public override string ToString()
        {
            return filmadi + " " + seans + " "  + tarih+ " " + salonno+" " ;
        }
        public static void gosterimgoster(List<Gosterim>gosterim1)
        {
            foreach (Gosterim item in gosterim1)
            {
                Console.WriteLine(item);
            }
        }
        public void koltuklarigoster()
        {
            foreach(Koltuk x in Koltuklar)
            {
                Console.WriteLine(x.koltukno);
                Console.WriteLine(x.sirano);
                Console.WriteLine(x.Koltukdurumu);
            }
        }
        public string Filmadi
      {
            get
            {
                return filmadi;
            }
            set
            {
                filmadi = value;
            }
      }
        public int Seans
        {
            get { return seans; }
            set { seans = value; }
        }
        public int Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }
        public int Salonadi
        {
            get { return salonno; }
            set { salonno = value; }
        }
    }
}
