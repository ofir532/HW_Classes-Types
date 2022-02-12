using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Classes_Types_09
{
    internal class Car : VeihcleBase
    {
        public int NumberOfDoors { get; set; }

        public override int GetMaxNumOfPassangers()
        {
            return NumberOfSits - 1;
        }

        public override int GetMaxSpeed()
        {
            return MaxSpeed;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nNumber of doors: {NumberOfDoors} \n----------------------\n";
        }
    }
}
