using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormKlass
{
    class Televisie
    {
        private int VolTeller = 0;
        //private int KanTeller = 0;
        private List<string> Kanaal = new List<string> {"BBC","Natinal Geography","RTL","Comedy","Mtv" };

        public void KanAalMin()
        {
          

        }
        public void VolVerhogen()
        {
            if (VolTeller<15)
            {
                VolTeller++;
                
            }
            else
            {
                MessageBox.Show($"Volume is on maximum: {VolTeller}");
            }
        }
        public void VolMin()
        {
            if (VolTeller>0 && VolTeller<=15)
            {
                VolTeller--;
            }
            else
            {
                MessageBox.Show($"Volume is on minimum {VolTeller}");
            }
        }
    }
}
