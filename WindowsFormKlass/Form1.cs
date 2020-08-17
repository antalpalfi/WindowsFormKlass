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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Teller MijnTeller = new Teller();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBekijk_Click(object sender, EventArgs e)
        {
            MijnTeller.Bekijken();
        }

        private void btnVerhoog_Click(object sender, EventArgs e)
        {
            MijnTeller.Verhogen();
        }

        private void btnVerlaag_Click(object sender, EventArgs e)
        {
            MijnTeller.Verlagen();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MijnTeller.Reset();
        }

        private void btnEind_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
