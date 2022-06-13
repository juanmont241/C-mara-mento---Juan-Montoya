using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Câmara_mento___Juan_Montoya
{
    public partial class OfficeScreen : UserControl
    {
        public static int endTimer;

        public OfficeScreen()
        {
            InitializeComponent();
            
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            endTimer++;

            clockTimer();
           


        }

        public void clockTimer()
        {
            if (endTimer >= 10 && endTimer <= 30)
            {
                amTimer.Text = "12am";
            }
            

            if (endTimer > 30 && endTimer <= 50)
             {
                amTimer.Text = "1am";
             }

            //else if (endTimer == 12000)
            //{
            //    amTimer.Text = "2am";
            //}

            //else if (endTimer == 180000)
            //{
            //    amTimer.Text = "3am";
            //}

            //else if (endTimer == 240000)
            //{
            //    amTimer.Text = "4am";
            //}

            //else if (endTimer == 300000)
            //{
            //    amTimer.Text = "5am";
            //}

            else if (endTimer == 60)
            {
                victoryResults();
                
            }
        }

        public void victoryResults()
        {
            Form1.ChangeScreen(this, new _6amScreen());
        }

        private void bringCamera_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new CameraWaitScreen());
        }

        private void hideTable_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new TableScreen());
        }

        private void CamDownTimer_Tick(object sender, EventArgs e)
        {
            camDown.Visible = false;
        }
    }
}
