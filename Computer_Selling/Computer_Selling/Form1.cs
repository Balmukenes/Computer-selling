using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Selling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int para = 0;
            int cpu = 0;
            if(rbCpui7.Checked)
            {
                cpu += 1000;
            }
            else if (rbCpui5.Checked)
            {
                cpu += 700;
            }
            else if(rbCpui3.Checked)
            {
                cpu += 500;
            }
            else if(rbCpuR5.Checked)
            {
                cpu += 800;
            }
            else if (rbCpuR3.Checked)
            {
                cpu += 400;
            }
            para += cpu;

            int gpu = 0;
            if (rbRtx3070.Checked)
            {
                gpu += 3000;
            }
            else if (rbRtx3050.Checked)
            {
                gpu += 1800;
            }
            else if (rbRx6600.Checked)
            {
                gpu += 2000;
            }
            else if (rbGtx1060.Checked)
            {
                gpu += 1500;
            }
            para += gpu;

            int anakart = 0;
            if (rbB550.Checked)
            {
                anakart += 1000;
            }
            else if (rbB450.Checked)
            {
                anakart += 800;
            }
            else if (rbA320.Checked)
            {
                anakart +=  500;
            }
            else if (rbA520m.Checked)
            {
                anakart += 300;
            }
            para += anakart;
            int ram = 0;
            if (rb32gb.Checked)
            {
                ram += 500;
            }
            else if (rb16gb.Checked)
            {
                ram += 300;
            }
            else if (rb8gb.Checked)
            {
                ram += 150;
            }
            para += ram;
            int depolama = 0;
            if (rb1tb.Checked)
            {
                depolama += 500;
            }
            else if (rb500gb.Checked)
            {
                depolama += 300;
            }
            else if (rb320gb.Checked)
            {
                depolama += 150;
            }
            para += depolama;
            label1.Text = Convert.ToString(para);

        }

        private void button1_Click(object sender, EventArgs e)
        {   
           Form3 frm3 =new Form3();
           frm3.Show();
            this.Hide();
        }
    }
}
