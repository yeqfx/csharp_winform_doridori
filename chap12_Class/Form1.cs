using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap12_Class
{
    public partial class Form1 : Form
    {
        Random _rd = new Random();

        structPlayer _sp1;
        structPlayer _sp2;

        Player _cPlayer = new Player();
        public Form1()
        {
            InitializeComponent();
        }

        private void pboxSun_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _sp1.iSun = iNumber;
            }
            else
            {
                _sp2.iSun = iNumber;
            }

            Result();
        }

        private void pboxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _sp1.iMoon = iNumber;
            }
            else
            {
                _sp2.iMoon = iNumber;
            }

            Result();
        }

        private void pboxStar_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _sp1.iStar = iNumber;
            }
            else
            {
                _sp2.iStar = iNumber;
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
                _sp1.iCount++;
                _sp1.iCardSum = _cPlayer.CardSum(_sp1.iSun, _sp1.iMoon, _sp1.iStar);
                strResult = _cPlayer.ResultText(_sp1.iCount, _sp1.iSun, _sp1.iMoon, _sp1.iStar, _sp1.iCardSum);
                lboxResult1.Items.Add(strResult);
            }
            else
            {
                _sp2.iCount++;
                _sp2.iCardSum = _cPlayer.CardSum(_sp2.iSun, _sp2.iMoon, _sp2.iStar);
                strResult = _cPlayer.ResultText(_sp2.iCount, _sp2.iSun, _sp2.iMoon, _sp2.iStar, _sp2.iCardSum);
                lboxResult2.Items.Add(strResult);
            }

            iCheckedChange();

            if (_sp1.iCount == _sp2.iCount)
            {
                lboxNow.Items.Add(_cPlayer.PlayerPair(_sp2.iCount, _sp1.iCardSum, _sp2.iCardSum));

                if (_sp2.iCount >= 5)
                {
                    lboxNow.Items.Add(_cPlayer.PlayerResult(_sp1.iCardSum, _sp2.iCardSum));
                }
            }
        }
    }
}
