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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnOefening1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnOefening2_Click(object sender, EventArgs e)
        {
            Oefening2 oef2 = new Oefening2();
            oef2.Show();
        }

        private void btnOefening3_Click(object sender, EventArgs e)
        {
            Oefening3 oef3 = new Oefening3();
            oef3.Show();
        }
    }
}
