using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Classes_Types_09
{
    internal abstract class VeihcleBase
    {
        public string  Model { get; set; }
        public int NumberOfSits { get; set; }
        public int MaxSpeed { get; set; }
        public int NumberOfwheels { get; set; }
        public abstract int GetMaxNumOfPassangers();
        public abstract int GetMaxSpeed();
        public override string ToString()
        {
            string text = null;
            text += $"Model: {Model}\n" +
                $"Number of sits: {NumberOfSits}\n" +
                $"Max speed: {MaxSpeed} km/h \n" +
                $"Number of wheels: {NumberOfwheels}";
            return text;
        }

    }



}
