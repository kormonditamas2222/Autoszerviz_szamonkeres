using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
        string rendszam;
        int kor;
        int kilometerOra;
        int uzemanyagSzint;

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            Rendszam = rendszam;
            Kor = kor;
            KilometerOra = kilometerOra;
            UzemanyagSzint = uzemanyagSzint;
        }

        public string Rendszam { get => rendszam; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    rendszam = "ISMERETLEN";
                }
                else
                {
                    rendszam = value;
                }
            }
        }
        public int Kor { get => kor; set => kor = Math.Clamp(value, 0, 50); }
        public int KilometerOra { get => kilometerOra; set => kilometerOra = Math.Max(0, value); }
        public int UzemanyagSzint { get => uzemanyagSzint; set => uzemanyagSzint = Math.Clamp(value, 0, 100); }
        public bool SzervizSzukseges { get => kilometerOra >= 200000; }

        public void InformaciotAd()
        {
            Console.WriteLine($"{rendszam} - {kor} éves jármű, {kilometerOra} km-rel.");
        }

        public void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                kilometerOra -= 10000;
                uzemanyagSzint -= 10;
                Console.WriteLine($"{rendszam} jármű szervizelése megtörtént.");
            }
        }
    }
}
