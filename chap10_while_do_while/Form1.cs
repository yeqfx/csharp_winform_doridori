﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap10_while_do_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnwhileResult_Click(object sender, EventArgs e)
        {
            int[] iArray = new int[6];
            int iCount = 0;

            StringBuilder sb = new StringBuilder();
            Random rd = new Random();

            // iArray 가 다 안찼으면 루프 진행
            while (Array.IndexOf(iArray, 0) != -1)
            {
                int iNumber = rd.Next(1, 46);

                if (Array.IndexOf(iArray, iNumber) == -1)
                {
                    iArray[iCount] = iNumber;
                    // sb.Append(string.Format("{0}, ", iNumber));
                    iCount++;
                }
            }

            Array.Sort(iArray);

            foreach (var item in iArray)
            {
                sb.Append(string.Format("{0}, ", item));
            }

            lblwhileResult.Text = sb.ToString();
            lboxwhileResult.Items.Add(sb.ToString());
        }

        private void btndowhileResult_Click(object sender, EventArgs e)
        {
            Random rd = new Random();

            int iNumber = int.Parse(tboxNumber.Text);

            if (iNumber < 1 || iNumber > 100)
            {
                MessageBox.Show("1~100 사이의 숫자를 입력해 주세요.");
                return;
            }

            int iCheckNumber = 0;
            int iCount = 0;

            do
            {
                iCheckNumber = rd.Next(1, 101);
                iCount++;
            } while (iNumber != iCheckNumber);
            lbldowhileResult.Text = string.Format("- 뽑은 숫자 {0}을 {1}회 만에 찾았습니다.", iNumber, iCount);
        }
    }
}
