using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle() 
        {
            
        }
        public bool HasSideCar { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle is in drive");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This { GetType().BaseType.Name} is a {GetType().BaseType.Name} that is virtually in drive");
        }
    }
}
