using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestProject
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnGetSum_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Sum is=" + MathHelper.GetSum(5, 10).ToString());
            this.lblResult.Text = string.Format("Result: {0}", MathHelper.GetSum(Convert.ToInt32(this.txtInput1.Text), Convert.ToInt32(this.txtInput2.Text)));
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            this.lblResult.Text = string.Format("Result: {0}", MathHelper.GetProduct(Convert.ToDouble(this.txtInput1.Text), Convert.ToDouble(this.txtInput2.Text)));
        }
    }
}
