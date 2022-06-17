using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class PrinterWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("Printer display dimension");
        }
        public virtual void Print()
        {
            Console.WriteLine("Printer printing");
        }
    }

    internal class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson display dimension : 10 * 11");
        }

        public override void Print()
        {
            Console.WriteLine("Epson printer printing");
        }
    }

    internal class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension : 9.5 * 12");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printer printing");
        }
    }

    internal class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaserJet display dimension : 12 * 12");
        }

        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing");
        }
    }
}
