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
    public partial class TableScreen : UserControl
    {
        public TableScreen()
        {
            InitializeComponent();
        }

        private void hideTable_Click(object sender, EventArgs e)
        {
            MenuScreen.gameSoundList[4].Play(); // Plays UnHideTable sound
            OfficeScreen.HidingTable = 0;
            Form1.ChangeScreen(this, new OfficeScreen());
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
          //  OfficeScreen.endTimer++;

            clockTimer();
        }

        public void clockTimer()
        {
            if (OfficeScreen.endTimer < 600)
            {
                amTimer.Text = "12am";
            }

            if (OfficeScreen.endTimer >= 600 && OfficeScreen.endTimer <= 1200)
            {
                amTimer.Text = "1am";
            }


            else if (OfficeScreen.endTimer > 1200 && OfficeScreen.endTimer <= 1800)
            {
                amTimer.Text = "2am";
            }

            else if (OfficeScreen.endTimer > 1800 && OfficeScreen.endTimer <= 2400)
            {
                amTimer.Text = "3am";
            }

            else if (OfficeScreen.endTimer > 2400 && OfficeScreen.endTimer <= 3000)
            {
                amTimer.Text = "4am";
            }

            else if (OfficeScreen.endTimer > 3000 && OfficeScreen.endTimer <= 3600)
            {
                amTimer.Text = "5am";
            }

            else if (OfficeScreen.endTimer == 4200)
            {
                victoryResults();
            }
        }

        public void victoryResults()
        {
            Form1.ChangeScreen(this, new _6amScreen());
        }
    }
}
