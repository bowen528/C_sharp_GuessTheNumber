using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Random rDice = new Random();
        int iPcAns, iPlrGes, iMinVal, iMaxVal;


        private void btn_Ges_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                iPlrGes = int.Parse(tbx_PlrGes.Text);
            }
            catch 
            {
                MessageBox.Show("輸入錯誤，系統自動填入中間值!");
                iPlrGes = (iMinVal + iMaxVal) / 2;
                tbx_PlrGes.Text = iPlrGes.ToString();

            }
            
            if (iPlrGes > iMinVal && iPlrGes < iMaxVal)
            {
                if (iPlrGes == iPcAns)
                {
                    MessageBox.Show("恭喜猜對，遊戲結束 ! ");
                    vGamelnit();
                }
                else 
                {
                    if (iPlrGes > iPcAns)
                    {
                        iMaxVal = iPlrGes;
                        lab_Max.Text = iMaxVal.ToString();
                        tbx_PlrGes.Text = "";
                    }
                    else 
                    {
                        iMinVal = iPlrGes;
                        lab_Min.Text = iMinVal.ToString();
                        tbx_PlrGes.Text = "";
                    }
                }
            }
            else 
            {
                MessageBox.Show("輸入錯誤，需介於 " + iMinVal + " 到 " + iMaxVal + " 之間~");
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            vGamelnit();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            vGamelnit();
        }

        private void vGamelnit()
        {
            
            iPcAns = rDice.Next(1, 1000);
            iMinVal = 0;  
            lab_Min.Text = iMinVal.ToString();
            iMaxVal = 1000;
            lab_Ans.Text = iPcAns.ToString();
            lab_Max.Text = iMaxVal.ToString();

            tbx_PlrGes.Text = "";
        }
    }
}
