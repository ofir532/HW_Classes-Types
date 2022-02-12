using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Classes_Types_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VeihcleBase vb1 = new Car() { Model = "BMW", NumberOfSits = 5, MaxSpeed = 160, NumberOfwheels = 4, NumberOfDoors = 5 };
            VeihcleBase vb2 = new Car() { Model = "Ferrari", NumberOfSits = 2, MaxSpeed = 300, NumberOfwheels = 4, NumberOfDoors = 2 };
            VeihcleBase vb3 = new Motorcycle() { Model = "Honda", NumberOfSits = 2, MaxSpeed = 140, NumberOfwheels = 2, NumberOfHandBrakes = 2 };
            VeihcleBase[] arrVb = { vb1,vb2,vb3};
            Carrier carrier = new Carrier(arrVb);
            Console.WriteLine(carrier);

        }
    }
}
