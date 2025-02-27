using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_02_21_AdatokGeneralasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int k = 10;
        int l = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Button gomb = new Button();
            gomb.Text = "új gomb";
            gomb.Name = "ujGomb";
            gomb.Width = button1.Width;
            gomb.Height = button1.Height;
            gomb.Location = new Point(200+k, 10);
            k += 10;
            this.Controls.Add(gomb);
            */
            List<Button> gombok = new List<Button>();
            int szam = 1;
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Button button = new Button();
                    gombok.Add(button);
                    button.Text = $"{szam}";
                    button.Name = "szamok";
                    button.Height = 30;
                    button.Width = 30;
                    button.Location = new Point(k, 100 + l);
                    button.Click += new EventHandler(GombKlick);
                    Controls.Add(button);
                    szam++;
                    k += 40;
                }
                k = 10;
                l += 40;
            }
            button1.Enabled = false;
        }
        private void GombKlick(object sender, EventArgs e)
        {
            Button gombSajatMaga = (Button)sender;
            MessageBox.Show(gombSajatMaga.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            Form2 UjAblak = new Form2(this, numericUpDown1);
            UjAblak.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        
        }
    }
}
