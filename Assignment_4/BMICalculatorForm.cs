using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class BMICalculatorForm : Form
    {
        double hinch;
        double wpound;
        double timperial;
        double tmetric;
         double wkg;
         double hmetres;

        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hinch = double.Parse(textBox1.Text);
            wpound = double.Parse(textBox2.Text);
            hmetres = double.Parse(textBox1.Text);
            wkg = double.Parse(textBox2.Text);
            if (radioimp.Checked)
            {
                timperial = (wpound * 703) / (hinch * hinch);
                textBox3.Text = String.Format("{0:f}", timperial);
            }
            else if(radiomet.Checked)
            {
                tmetric = (wkg) / (hmetres * hmetres);
                textBox3.Text = String.Format("{0:f}", tmetric);
            }


            if (timperial<24.9)
            {
                textBox3.BackColor = Color.Aqua;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioimp_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

        
        
             
                
            
        }

        private void radiomet_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
