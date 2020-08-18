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
            txtWiskunde.Focus();
            
        }

        private void btnWisRem_Click(object sender, EventArgs e)
        {
            Rapport mijnRapport = new Rapport();
            mijnRapport.WiskundeList.Remove(listBoxWiskunde.SelectedIndex);
            listBoxWiskunde.Items.Remove(listBoxWiskunde.SelectedItem);
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
            labelWiskunde.Text = $"Gemiddelde: {Math.Round(gemid, 2)}";





        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            Rapport mijnRapport = new Rapport();
            int x = Int32.Parse(txtCom.Text);
            mijnRapport.ComputerList.Add(x);
            foreach (var item in mijnRapport.ComputerList)
            {
                listBoxComputer.Items.Add(item);
            }
            double gemid = 0, som = 0;
            for (int i = 0; i < listBoxComputer.Items.Count; i++)
            {
                som += Convert.ToDouble(listBoxComputer.Items[i]);
            }
            gemid = som / listBoxComputer.Items.Count;
            labelComp.Text = $"Gemiddelde: {Math.Round(gemid, 2)}";
            txtCom.Clear();
            txtCom.Focus();
        }

        private void btnCompRem_Click(object sender, EventArgs e)
        {
            Rapport mijnRapport = new Rapport();
            mijnRapport.ComputerList.Remove(listBoxComputer.SelectedIndex);
            listBoxComputer.Items.Remove(listBoxComputer.SelectedItem);
            foreach (var item in mijnRapport.WiskundeList)
            {
                listBoxComputer.Items.Add(item);
            }
            double gemid = 0, som = 0;
            for (int i = 0; i < listBoxComputer.Items.Count; i++)
            {
                som += Convert.ToDouble(listBoxComputer.Items[i]);
            }
            gemid = som / listBoxComputer.Items.Count;
            labelComp.Text = $"Gemiddelde: {Math.Round(gemid, 2)}";
        }

        private void btnGrammatica_Click(object sender, EventArgs e)
        {
            Rapport mijnRapport = new Rapport();
            int x = Int32.Parse(txtGram.Text);
            mijnRapport.GrammList.Add(x);
            foreach (var item in mijnRapport.GrammList)
            {
                listBoxGramm.Items.Add(item);
            }
            double gemid = 0, som = 0;
            for (int i = 0; i < listBoxGramm.Items.Count; i++)
            {
                som += Convert.ToDouble(listBoxGramm.Items[i]);
            }
            gemid = som / listBoxGramm.Items.Count;
            labelGramm.Text = $"Gemiddelde: {Math.Round(gemid, 2)}";
            txtGram.Clear();
            txtGram.Focus();
        }

        private void btnGrammRem_Click(object sender, EventArgs e)
        {
            Rapport mijnRapport = new Rapport();
            mijnRapport.GrammList.Remove(listBoxGramm.SelectedIndex);
            listBoxGramm.Items.Remove(listBoxGramm.SelectedItem);
            foreach (var item in mijnRapport.GrammList)
            {
                listBoxGramm.Items.Add(item);
            }
            double gemid = 0, som = 0;
            for (int i = 0; i < listBoxGramm.Items.Count; i++)
            {
                som += Convert.ToDouble(listBoxGramm.Items[i]);
            }
            gemid = som / listBoxGramm.Items.Count;
            labelGramm.Text = $"Gemiddelde: {Math.Round(gemid, 2)}";
        }
    }
}
