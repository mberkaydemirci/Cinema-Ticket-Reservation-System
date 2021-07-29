using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne
{

    class Koltuk
    {
        public int sirano, koltukno;
        private string koltukdurumu;
        public Koltuk(int sirano, int koltukno, string koltukdurumu)
        {
            this.sirano = sirano;
            this.koltukno = koltukno;
            this.koltukdurumu = koltukdurumu;
        }
        public Koltuk()
        {
            
        }
        public override string ToString()
        {
            return sirano+" " +koltukno+" " + koltukdurumu;            
        }
        public static void koltuklistesigoster(List<Koltuk>Koltuklar1)
        {
            for (int i = 0; i < Koltuklar1.Count; i++)
            {
                Console.WriteLine(Koltuklar1[i]);
            }

        }
        public string Koltukdurumu
        {
            get
            {
                return koltukdurumu;
            }
            set
            {
                koltukdurumu = value;
            }
        }
        public void KoltukAyir(int koltukno,int sirano,string koltukdurumu)
        {
            if(koltukdurumu=="bos")
            {
                Console.WriteLine("Koltuk Musaittir Rezerve Ediliyor...");
                koltukdurumu = "dolu";
                Console.WriteLine("Koltuk Basariyle Rezerve Edilmistir");
            }
            else
            {
                Console.WriteLine("Koltuk Dolu ...");
            }
        }      
    }
}
