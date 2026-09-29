using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Szerviz
    {
        List<Jarmu> jarmuvek;
        public Szerviz()
        {
            jarmuvek = new List<Jarmu>();
        }

        public void JarmuFelvetele(Jarmu jarmu)
        {
            jarmuvek.Add(jarmu);
            Console.WriteLine($"{jarmu.Rendszam} megérkezett a szervizbe");
        }
        public void InformaciokListazasa()
        {
            foreach (Jarmu jarmu in jarmuvek)
            {
                if (jarmu is ElektromosAuto elektromos)
                {
                    elektromos.InformaciotAd();
                }
                else if (jarmu is TeherAuto teherauto)
                {
                    teherauto.InformaciotAd();
                }
                else
                {
                    jarmu.InformaciotAd();
                }
            }
        }
        public void CsoportosSzerviz(int dij)
        {
            foreach (Jarmu jarmu in jarmuvek)
            {
                if (jarmu.SzervizSzukseges)
                {
                    if (jarmu is ElektromosAuto elektromos)
                    {
                        elektromos.Szervizel(dij);
                    }
                    else if (jarmu is TeherAuto teherauto)
                    {
                        teherauto.Szervizel(dij);
                    }
                    else
                    {
                        jarmu.Szervizel(dij);
                    }
                }
                else
                {
                    Console.WriteLine($"{jarmu.Rendszam} szervizelése jelenleg nem szükséges.");
                }
            }
        }
    }
}
