using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
           
            int mult;
            num1 = Convert.ToInt32(textBox1.Text);
            
            mult = num1 * 25;

            label2.Text = "This years revenue is" + mult;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void changeOutputButton_Click(object sender, EventArgs e)
        {
            int num2;
            int sum;
            int mult2;
            num2 = Convert.ToInt32(textBox2.Text);
            mult2 = num2 * 25;
            label2.Text = "Next years revenue will be" + mult2;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
