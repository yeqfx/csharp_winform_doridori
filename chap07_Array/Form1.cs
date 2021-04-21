using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap07_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgDay.Rows.Clear();

            int[] iTest = { 10, 5, 30, 4, 15, 22, 18 };

            lblArrayCount.Text = String.Format("전체 자료 수 : {0}", iTest.Length.ToString());

            for (int i = 0; i < 7; i++) dgDay["colDay" + (i + 1), 0].Value = iTest[i];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgDay.Rows.Clear();

            int[,] iTest = { { 10, 5, 30, 4, 15, 22, 18 }, { 11, 15, 20, 14, 15, 23, 17 } };

            lblArrayCount.Text = String.Format("전체 자료 수 : {0}", iTest.Length.ToString());

            dgDay.Rows.Add();

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 7; j++)
                    dgDay["colDay" + (j + 1), i].Value = iTest[i, j];
        }
    }
}
