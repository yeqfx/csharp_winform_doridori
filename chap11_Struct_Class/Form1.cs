﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap11_Struct_Class
{
    struct structPlayer
    {
        public int iCount;

        public int iSun;
        public int iMoon;
        public int iStar;

        public int iCardSum;

        public int CardSum(int iSum, int iMoon, int iStar)
        {
            return iSun + iMoon + iStar;
        }

        public string ResultText()
        {
            return string.Format("{0}회) 해:{1}, 달:{2}, 별:{3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
        }
    }
    public partial class Form1 : Form
    {
        structPlayer _stPlayer1;
        structPlayer _stPlayer2;

        Random _rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void pBoxSun_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iSun = iNumber;
            }
            else
            {
                _stPlayer2.iSun = iNumber;
            }

            Result();
        }

        private void pboxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iMoon = iNumber;
            }
            else
            {
                _stPlayer2.iMoon = iNumber;
            }

            Result();

        }

        private void pboxStar_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iStar = iNumber;
            }
            else
            {
                _stPlayer2.iStar = iNumber;
            }

            Result();

        }

        private void pboxNone_Click(object sender, EventArgs e)
        {
            Result();
        }

        private void iCheckedChange()
        {
            if (rdoPlayer1.Checked)
            {
                rdoPlayer2.Checked = true;
            }
            else
            {
                rdoPlayer1.Checked = true;
            }
        }

        private void Result()
        {
            string strResult = string.Empty;

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iCount++;
                _stPlayer1.iCardSum = _stPlayer1.CardSum(_stPlayer1.iSun, _stPlayer1.iMoon, _stPlayer1.iStar);
                strResult = _stPlayer1.ResultText();
                lboxResult1.Items.Add(strResult);
            }
            else
            {
                _stPlayer2.iCount++;
                _stPlayer2.iCardSum = _stPlayer2.CardSum(_stPlayer2.iSun, _stPlayer2.iMoon, _stPlayer2.iStar);
                strResult = _stPlayer2.ResultText();
                lboxResult2.Items.Add(strResult);
            }

            iCheckedChange();

            if (_stPlayer1.iCount >= 5 && _stPlayer2.iCount >= 5)
            {
                if (_stPlayer1.iCardSum > _stPlayer2.iCardSum)
                {
                    MessageBox.Show("Player1이 이겼습니다.");
                }
                else if (_stPlayer1.iCardSum < _stPlayer2.iCardSum)
                {
                    MessageBox.Show("Player2가 이겼습니다.");
                }
                else
                {
                    MessageBox.Show("비겼습니다.");
                }
            }
        }
    }
}
