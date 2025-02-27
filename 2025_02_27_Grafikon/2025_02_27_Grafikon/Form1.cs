using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _2025_02_27_Grafikon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdatokFeltoltese();
            GrafikonMegjelenitese();
        }

        private void GrafikonMegjelenitese()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Számok");
            chart1.Series[0].ChartType = SeriesChartType.Line;
            int n = listBox1.Items.Count;
            for(int i = 0; i < n; i++)
            {
                chart1.Series[0].Points.Add(int.Parse(""+listBox1.Items[i]));
            }
        }

        private void AdatokFeltoltese()
        {
            listBox1.Items.Clear();
            int n = (int)numericUpDown1.Value;
            Random r = new Random();
            for(int i = 0;i < n; i++)
            {
                listBox1.Items.Add(r.Next(10, 99));
            }
        }
    }
}
