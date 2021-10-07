using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            try
            {
                double height = double.Parse(txtHeight.Text);
                double weight = double.Parse(txtWeight.Text);
                //calculate BMI
                double bmi = ((weight*703)/(height*height));

                //displaying result
                lblResult.Text = "Your BMI is " + bmi;
            }
            
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

