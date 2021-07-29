using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mehme\Desktop\Ders\Ders\2.sınıf\nesne\nesne\nesne\sinema.txt");
                List<Gosterim> gosterimler1 = new List<Gosterim>();
                List<Koltuk> denemekoltuk = new List<Koltuk>();

                foreach (string x in lines)
                {
                    Koltuk koltuklar1 = new Koltuk();
                    string a = x.Replace(" ", "");
                    string[] lines1 = a.Split(',');

                    for (int i = 0; i < lines1.Length; i++)
                    {
                        if (i == 0)
                        {
                            Gosterim gosterim1 = new Gosterim(Convert.ToInt32(lines1[i])); // dosyada sadece salon no yazdığı için tek elemanlı yazdırdım 
                            gosterimler1.Add(gosterim1);                                    //istenirse çok elemanlı oluşturalabilir
                        }
                        else if (i == 1)
                        {
                            koltuklar1.sirano = Convert.ToInt32(lines1[i]);
                        }
                        else if (i == 2)
                        {
                            koltuklar1.koltukno = Convert.ToInt32(lines1[i]);
                        }
                        else if (i == 3)
                        {

                            koltuklar1.Koltukdurumu = lines1[i];
                            denemekoltuk.Add(koltuklar1);
                        }


                    }

                }
                Koltuk.koltuklistesigoster(denemekoltuk);
                Gosterim.gosterimgoster(gosterimler1);
                List<Bilet> Biletler = new List<Bilet>(); 
                Bilet biletci = new Bilet("Mehmet Berkay", "Demirci", 6856, 15);
                Biletler.Add(biletci);
                biletci.bilgi(Biletler);             //bilet yazdırma veya gönderme
                List<Bilet> Biletlergonder = biletci.bilgi(Biletler);
                biletci.Biletokut(Biletlergonder);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
