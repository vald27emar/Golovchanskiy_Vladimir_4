using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Stringed : Instrument
    {
        public Stringed(string name, bool isTuned = false) : base(name)
        {
            IsTuned = isTuned;
        }
        public override void ReproduceTheSounds()
        {
            if (IsTuned)
                Console.WriteLine($"{Name}: *Дзунь зу*");
        }
        public override void TuneTheInstrument()
        {
            IsTuned = true;
        }
    }
}