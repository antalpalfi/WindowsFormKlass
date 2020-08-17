using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormKlass
{
    class Rapport
    {
        public List<int> WiskundeList { get; set; }
        public List<int> ComputerList { get; set; }
        public List<int> GrammList  { get; set; }

        public Rapport()
        {
            WiskundeList = new List<int>();
            ComputerList = new List<int>();
            GrammList = new List<int>();
        }
       
        

    
    }
}
