using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    abstract class Instrument
    {
        public string Name { get; set; }
        public bool IsTuned { get; set; }
        public Instrument(string name)
        {
            Name = name;
        }
        abstract public void TuneTheInstrument();
        abstract public void ReproduceTheSounds();
        public void ShowMusicalInstrument()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return Name;
        }
    }
    internal class Orchestra
    {
        private List<Instrument> InstrumentList = new List<Instrument>();
        public Orchestra()
        {
            InstrumentList.Add(new Shock(name: "Барабан", isTuned: true));
            InstrumentList.Add(new Stringed(name: "Скрипка", isTuned: true));
            InstrumentList.Add(new Spiritual(name: "Сопiлка", isTuned: true));
        }
        public void GiveTheOrchestra()
        {
            foreach (var musicalinstrument in InstrumentList)
            {
                musicalinstrument.ShowMusicalInstrument();
            }
        }
        public void GiveTheSounds()
        {
            foreach (var musicalinstrument in InstrumentList)
            {
                musicalinstrument.ReproduceTheSounds();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Orchestra orchestra = new Orchestra();
            Console.WriteLine("Склад оркестру:");
            orchestra.GiveTheOrchestra();
            Console.WriteLine("\nЗвуки iнструментiв:");
            orchestra.GiveTheSounds();
        }
    }
}
