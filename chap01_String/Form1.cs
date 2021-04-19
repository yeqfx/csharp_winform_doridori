using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap01_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strText = lblText.Text;

            lblContain.Text = strText.Contains("Text").ToString();
            lblEquals.Text = strText.Equals("Test").ToString();
            lblLength.Text = strText.Length.ToString();
            lblReplace.Text = strText.Replace("Test", "I Can").ToString();

            string[] strSplit = strText.Split(',');
            lblSplit1.Text = strSplit[0].ToString();
            lblSplit2.Text = strSplit[1].ToString();
            lblSplit3.Text = strSplit[2].ToString();

            lblSubstring.Text = strText.Substring(3, 5).ToString();
            lblTolower.Text = strText.ToLower().ToString();
            lblToupper.Text = strText.ToUpper().ToString();
            lblTrim.Text = strText.Trim().ToString();
        }
    }
}
