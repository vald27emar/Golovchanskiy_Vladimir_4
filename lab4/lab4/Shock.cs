using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Shock : Instrument
    {
        public Shock(string name, bool isTuned = true) : base(name)
        {
            IsTuned = isTuned;
        }
        public override void ReproduceTheSounds()
        {
            if (IsTuned)
                Console.WriteLine($"{Name}: *Бум бум бум*");
        }
        public override void TuneTheInstrument()
        {
            IsTuned = true;
        }
    }
}