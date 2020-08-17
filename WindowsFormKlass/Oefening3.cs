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
    public partial class Oefening3 : Form
    {
        public Oefening3()
        {
            InitializeComponent();
        }

        private void btnWiskunde_Click(object sender, EventArgs e)
        {
            Rapport mijnRapport = new Rapport();
            int x = Int32.Parse(txtWiskunde.Text);
            mijnRapport.WiskundeList.Add(x);
            foreach (var item in mijnRapport.WiskundeList)
            {
                listBoxWiskunde.Items.Add(item);
            }
            double gemid = 0, som = 0;
            for (int i = 0; i < listBoxWiskunde.Items.Count; i++)
            {
                som += Convert.ToDouble(listBoxWiskunde.Items[i]);
            }
            gemid = som / listBoxWiskunde.Items.Count;
            labelWiskunde.Text = $"Gemiddelde: {Math.Round(gemid,2)}";

            txtWiskunde.Clear();
            
        }

        private void btnWisRem_Click(object sender, EventArgs e)
        {
            Rapport mijnRapport = new Rapport();
            //deletRapport.WiskundeList.RemoveAt(listBoxWiskunde.SelectedIndex);
           
            listBoxWiskunde.Items.Remove(listBoxWiskunde.SelectedItem);
            

           
            //deletRapport.WiskundeList.RemoveAt(listBoxWiskunde.SelectedItem);

        }
    }
}
