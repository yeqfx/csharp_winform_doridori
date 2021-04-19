using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap02_DataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            try
            {
                short sNumber = short.Parse(tBoxNumber.Text);

                lblShort.Text = sNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();                
            }

        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            try
            {
                int sNumber = int.Parse(tBoxNumber.Text);

                lblInt.Text = sNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            try
            {
                double sNumber = double.Parse(tBoxNumber.Text);

                lblDouble.Text = sNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            short sNumber = 0;
            int iNumber = 0;
            double dNumber = 0;

            if (short.TryParse(tBoxNumber.Text, out sNumber))
            {
                lblShort.Text = sNumber.ToString();
            } else if (int.TryParse(tBoxNumber.Text, out iNumber))
            {
                lblInt.Text = iNumber.ToString();
            } else if (double.TryParse(tBoxNumber.Text, out dNumber))
            {
                lblDouble.Text = dNumber.ToString();
            } else
            {
                lblException.Text = "변환할 수 없음";
            }


        }

    }
}
