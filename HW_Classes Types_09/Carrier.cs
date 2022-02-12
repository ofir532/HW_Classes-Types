using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Classes_Types_09
{
    internal class Carrier
    {
        public VeihcleBase[] Vehicles { get; set; }
        public Carrier(VeihcleBase[] Vehicles)
        {
            this.Vehicles = new VeihcleBase[Vehicles.Length];
           for(int i = 0; i < Vehicles.Length; i++)
            {
                this.Vehicles[i] = Vehicles[i];
            }
        }
        public override string ToString()
        {
            string text = null;
            foreach(var v in Vehicles)
            {
                text += v.ToString();
            }
            return text;    
        }
    }
}
