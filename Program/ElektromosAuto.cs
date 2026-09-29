using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ElektromosAuto : Jarmu
    {
        int akkumulatorSzint;

        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int akkumulatorSzint) : base(rendszam, kor, kilometerOra, 0)
        {
            AkkumulatorSzint = akkumulatorSzint;
        }
        public int AkkumulatorSzint { get => akkumulatorSzint; set => akkumulatorSzint = Math.Clamp(value, 0, 100); }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves elektromos autó, {KilometerOra} km-rel, {AkkumulatorSzint}% töltöttséggel.");
        }

        public override void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }
            Console.WriteLine($"{Rendszam} jármű szervizelése megtörtént.");
            akkumulatorSzint += 20;
        }
    }
}
