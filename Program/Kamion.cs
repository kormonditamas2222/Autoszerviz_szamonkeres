using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Kamion : Jarmu
    {
        int hossz;

        public Kamion (string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int hossz) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            Hossz = hossz;
        }

        public int Hossz { get => hossz; set => hossz = Math.Clamp(value, 4, 20); }

        public override void InformaciotAd()
        {
            if (hossz < 7)
            {
                Console.WriteLine($"{Rendszam} kamion, {KilometerOra} km-rel, hossza: {Hossz} m, nincs rá csatolva semmi");
            }
            else
            {
                Console.WriteLine($"{Rendszam} kamion, {KilometerOra} km-rel, hossza: {Hossz} m, van rajta csatolt egység");
            }
        }

        public override void Szervizel(int dij)
        {
            if (hossz < 7)
            {
                base.Szervizel(dij);
            }
            else
            {
                Console.WriteLine("Ez a kamion nem szervizelhető, mert van rajta csatolt egység.");
            }
        }
    }
}
