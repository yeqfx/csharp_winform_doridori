using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap08_if_switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnifResult_Click(object sender, EventArgs e)
        {
            var iNumber1 = nNumber1.Value;
            var iNumber2 = nNumber2.Value;

            if (iNumber1 > iNumber2)
            {
                lblifResult.Text = String.Format("- Number1이 Number2 보다 {0} 더 큽니다.", iNumber1 - iNumber2);
            }
            else if (iNumber1 < iNumber2)
            {
                lblifResult.Text = String.Format("- Number2가 Number1 보다 {0} 더 큽니다.", iNumber2 - iNumber1);
            }
            else
            {
                lblifResult.Text = String.Format("- 두 숫자는 같습니다. 숫자 : {0}", iNumber1);
            }
        }

        private void btnswitchResult_Click(object sender, EventArgs e)
        {
            string strSelect = cboxDay.Text;

            switch (strSelect)
            {
                case "월":
                    lblswitchResult.Text = "- 선택 날짜는 월요일입니다.";
                    break;
                case "화":
                    lblswitchResult.Text = "- 선택 날짜는 화요일입니다.";
                    break;
                case "수":
                    lblswitchResult.Text = "- 선택 날짜는 수요일입니다.";
                    break;
                case "목":
                case "금":
                    lblswitchResult.Text = "- 선택 날짜는 목요일 또는 금요일입니다.";
                    break;
                default:
                    lblswitchResult.Text = "- 선택 날짜는 주말입니다.(토요일 또는 일요일)";
                    break;
            }
        }
    }
}
