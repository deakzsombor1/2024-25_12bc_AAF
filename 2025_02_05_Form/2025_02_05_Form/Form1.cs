using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_02_05_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //decimal osszeg = szam1.Value + szam2.Value;
            int osszeg = (int)(szam1.Value + szam2.Value);
            eredmeny.Text = "" + osszeg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            muveletCombo.Text = "" + muveletCombo.Items[0];
            if(muveletCombo.Text == "+")
            {
                int osszeadas = (int)(szam1.Value + szam2.Value);
                eredmeny.Text = "" + osszeadas;
            }
            else if (muveletCombo.Text == "-")
            {
                int kivonas = (int)(szam1.Value - szam2.Value);
                eredmeny.Text = "" + kivonas;
            }
            else if (muveletCombo.Text == "*"){
                int szorzas = (int)(szam1.Value * szam2.Value);
                eredmeny.Text = "" + szorzas;
            }
            else if (muveletCombo.Text == "/")
            {
                int osztas = (int)(szam1.Value / szam2.Value);
                eredmeny.Text = "" + osztas;
            }
            else if (muveletCombo.Text == "maradék")
            {
                int szorzas = (int)(szam1.Value  szam2.Value);
                eredmeny.Text = "" + szorzas;
            }
        }
    }
}
