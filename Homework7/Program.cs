using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Computer
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string ProcessorType { get; set; }
        public string ProcessorFrequency { get; set; }
        public int RAMsize { get; set; }
        public string Harddiskspace { get; set; }
        public string Videocardmemory { get; set; }
        public double Cost { get; set; }
        public int Numberofunits { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> listComputers = new List<Computer>()
            {
                new Computer(){Id=1,Brand="Hewlett-Packard", ProcessorType= "AMD",ProcessorFrequency = "3.2 Ггц", RAMsize= 16, Harddiskspace ="1 Тб", Videocardmemory ="2 Гб", Cost=150, Numberofunits=30 },
                new Computer(){Id=2,Brand="Acer", ProcessorType= "Pentium",ProcessorFrequency = "3.8 Ггц", RAMsize= 16, Harddiskspace ="1 Тб", Videocardmemory ="2 Гб", Cost=200, Numberofunits=30 },
                new Computer(){Id=3,Brand="Hewlett-Packard", ProcessorType= "Pentium",ProcessorFrequency = "4.3 Ггц", RAMsize= 32 , Harddiskspace ="1 Тб", Videocardmemory ="4 Гб", Cost=400, Numberofunits=30 },
                new Computer(){Id=4,Brand="Asus", ProcessorType= "AMD",ProcessorFrequency = "3.8 Ггц", RAMsize= 8 , Harddiskspace ="1 Тб", Videocardmemory ="2 Гб", Cost=100, Numberofunits=30 },
                new Computer(){Id=5,Brand="Acer", ProcessorType= "AMD",ProcessorFrequency = "3.2 Ггц", RAMsize= 8, Harddiskspace ="1 Тб", Videocardmemory ="1 Гб", Cost=200, Numberofunits=30 },
                new Computer(){Id=6,Brand="Hewlett-Packard", ProcessorType= "Pentium",ProcessorFrequency = "3.8 Ггц", RAMsize= 16, Harddiskspace ="1 Тб", Videocardmemory ="2 Гб", Cost=250, Numberofunits=30 }

            };
            double min = listComputers
                .Min(t1 => t1.Cost);

            var computers1 = listComputers
                            .Where(n => n.Cost == max);
            foreach (var n1 in computers1)
            {
                Console.WriteLine($" {n1.Id} { n1.Brand} {n1.ProcessorType}  {n1.RAMsize} {n1.Harddiskspace} {n1.Videocardmemory} {n1.Cost} {n1.Numberofunits}");
            }
            Console.ReadKey();
        }
    }
}
