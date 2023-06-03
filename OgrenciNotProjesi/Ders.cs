using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotProjesi
{
    public class Ders
    {
        public string DersDonemi { get; set; }
        public string DersKodu { get; set; }
        public string DersAdi { get; set; }
        public int DersKredisi { get; set; }
        public string HarfNotu { get; set; }
        public Ders()
        {

        }
        public Ders(string dersKodu, string dersAdi, int dersKredisi, string harfNotu,string donem)
        {
            DersKodu = dersKodu;
            DersAdi = dersAdi;
            DersKredisi = dersKredisi;
            HarfNotu =harfNotu;
            DersDonemi = donem; 
         }

        public override string ToString()
        {
            return DersKodu + " " + DersAdi + " " + DersKredisi + " " + HarfNotu + " " + DersDonemi;
        }

    }
}
