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
    public partial class Oefening4 : Form
    {
        public Oefening4()
        {
            InitializeComponent();
        }
        Zwembad zwWembad = new Zwembad();

        private void btKalk_Click(object sender, EventArgs e)
        {
            zwWembad.lenght = decimal.ToDouble(numLenght.Value);
            zwWembad.depth = decimal.ToDouble(numDept.Value);
            zwWembad.breed = decimal.ToDouble(numBreed.Value);

            zwWembad.Water();
            MessageBox.Show($"{zwWembad.water.ToString()} L water kan invullen");
            numBreed.Value =0;
            numDept.Value = 0;
            numLenght.Value = 0;
            
        }
    }
}
