using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormKlass
{
    public partial class Oefening2 : Form
    {
        public Oefening2()
        {
            InitializeComponent();
        }
        private Televisie VolTeller = new Televisie();
        private void btnVolPlus_Click(object sender, EventArgs e)
        {
            VolTeller.VolVerhogen();
        }

        private void btnVolMin_Click(object sender, EventArgs e)
        {
            VolTeller.VolMin();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
