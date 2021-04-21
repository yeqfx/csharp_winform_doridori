using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap06_comments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tboxComment1.Text = "코드에 설명을 붙일 때 사용합니다.";
            tboxComment2.Text = "사용하지 않는 줄을 임시로 막아 놓을 경우 사용합니다.";
            tboxComment3.Text = "여러 줄을 동시에 막을 경우 사용합니다.";
            tboxComment4.Text = "" +
                "///<summary>\r\n" +
                "///메소드에 대해 설명이 필요 할 경우 사용합니다. (인자에 대한 설명을 포함할 경우에도 사용합니다.\r\n" +
                "///</summary>\r\n" +
                "<param name=\"strName\">인수에 대한 설명을 입력합니다.</param>\r\n" +
                "<returns>반환값에 대한 설명을 입력합니다.</return>";

        }

        
    }
}
