using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginForm
{
    internal class Auto
    {
        public string Rendszam { get; set; }
        public string Marka { get; set; }
        public string Modell { get; set; }
        public int GyartasiEv { get; set; }
        public DateTime ForgalmiErvenyesseg { get; set; }
        public int VetelAr { get; set; }
        public int KmAllas { get; set; }
        public int Hengerurtartalom { get; set; }
        public int Tomeg { get; set; }
        public int Teljesitmeny { get; set; }

        public Auto(string rendszam, string marka, string modell, int gyartasiEv, DateTime forgalmiErvenyesseg,
                    int vetelAr, int kmAllas, int hengerurtartalom, int tomeg, int teljesitmeny)
        {
            Rendszam = rendszam;
            Marka = marka;
            Modell = modell;
            GyartasiEv = gyartasiEv;
            ForgalmiErvenyesseg = forgalmiErvenyesseg;
            VetelAr = vetelAr;
            KmAllas = kmAllas;
            Hengerurtartalom = hengerurtartalom;
            Tomeg = tomeg;
            Teljesitmeny = teljesitmeny;
        }

        public string AutoKiirasa
        {
            get { return $"{Rendszam} - {Marka} {Modell} ({GyartasiEv})"; }
        }
    }
}
