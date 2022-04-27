using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gurtmaß_Rechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rechnenButton_Click(object sender, EventArgs e)
        {
            double length;
            double width;
            double height;

            double DHLNationalMax = 360;
            double DHLInternationalMax = 300;
            double DHLMaxLength = 200;

            double GLSMax = 300;
            double GLSMaxLength = 200;
            double GLSMaxWidth = 80;
            double GLSMaxHeight = 60;

            double DPDMax = 300;
            double DPDMaxLength = 175;

            checkedListBox1.SetItemCheckState(0, CheckState.Unchecked);
            checkedListBox1.SetItemCheckState(1, CheckState.Unchecked);
            checkedListBox1.SetItemCheckState(2, CheckState.Unchecked);
            checkedListBox1.SetItemCheckState(3, CheckState.Unchecked);



            if (LaengeInput.Text == "")
            {
                
            }
            

            else if (BreiteInput.Text == "")
            {

            }

            else if (HeightInput.Text == "")
            {

            }

            else
            {
                length = Convert.ToDouble(LaengeInput.Text);
                width = Convert.ToDouble(BreiteInput.Text);
                height = Convert.ToDouble(HeightInput.Text);

                double gurtmass = length + (2 * width) + (2 * height);
                gurtmassresult.Text = gurtmass.ToString();

                if(gurtmass <= DHLNationalMax && length <= DHLMaxLength)
                {
                    checkedListBox1.SetItemCheckState(0, CheckState.Checked);
                }
                if (gurtmass <= DHLInternationalMax && length <= DHLMaxLength)
                {
                    checkedListBox1.SetItemCheckState(1, CheckState.Checked);
                }
                if (gurtmass <= GLSMax && length <= GLSMaxLength && width <= GLSMaxWidth && height <= GLSMaxHeight)
                {
                    checkedListBox1.SetItemCheckState(2, CheckState.Checked);
                }
                if (gurtmass <= DPDMax && length <= DPDMaxLength)
                {
                    checkedListBox1.SetItemCheckState(3, CheckState.Checked);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
