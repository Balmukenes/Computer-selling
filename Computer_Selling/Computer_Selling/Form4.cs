using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Selling
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            Form4 frm4 = new Form4();            
            Form5 frm5 = new Form5();
            Form6 frm6 = new Form6();

            int pc = Convert.ToInt32(textBox1.Text);
            if (pc > 0 && pc <= 10000)
            {
                frm2.Show();
                this.Hide();
            }
            else if (pc > 10001 && pc <= 20000)
            {
                frm5.Show();
                this.Hide();
            }
            else if (pc > 20001 && pc <= 30000)
            {
                frm6.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlıs Bütçe Girdiniz");
                frm4.Show();
                this.Hide();
            }
            
        }
    }
}
