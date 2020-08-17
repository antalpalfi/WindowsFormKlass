using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormKlass
{
    public class Zwembad
    {
        public double lenght { get; set; }
        public double breed { get; set; }
        public double depth { get; set; }
        public double  water { get; set; }
        public void Water()
        {
            water = lenght * breed * depth;
        }
    }
}
