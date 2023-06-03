using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotProjesi
{
    public class Ogrenci
    {

        public List<Ders> Donemler;
        public double GenelOrtalamasi { get; set; }
       public double ToplamKredi { get; set; }   
        public  string Adi { get; set; }
        public string Soyadi { get; set; }

        private int ogrenciNumarasi;

        public int OgrenciNumarasi
        {
            get { return ogrenciNumarasi; }
            set
            {
                // Öğrenci numarası sadece int türünden değerler alacak
                if (value.GetType() != typeof(int))
                {
                   Console.WriteLine("Öğrenci numarası sadece sayısal bir değer olmalıdır.");
                }

                if (value < 0)
                {
                    Console.WriteLine("Öğrenci numarası negatif olamaz.");
                }

                ogrenciNumarasi = value;
            }
        }

        public override string ToString()
        {
            return Adi + " " + Soyadi + " " + OgrenciNumarasi;
        }

    }
}
