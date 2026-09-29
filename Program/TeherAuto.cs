using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class TeherAuto : Jarmu
    {
        int rakomany;

        public TeherAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int rakomany) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            Rakomany = rakomany;
        }

        public int Rakomany { get => rakomany; set => rakomany = Math.Clamp(value, 0, 20); }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves teherautó, {KilometerOra} km-rel, rakomány: {Rakomany} tonna");
        }
        public override void Szervizel(int dij)
        {
            Rakomany = 0;
            base.Szervizel(dij);
        }
    }
}
