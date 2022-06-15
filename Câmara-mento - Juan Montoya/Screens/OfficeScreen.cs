﻿using System;
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

        Mascot Undying;
        Mascot Bridget;
        Mascot TheFace;
        Mascot Jake;

        Random randGen = new Random(); //Declaring the Random Genrator

        public OfficeScreen()
        {
            SetUpMascots();
            InitializeComponent();
            
        }

       public void SetUpMascots()
        {
            //
            //  0=Office,  1=Char Prep,   2=Roof,   3=Locker,   4=OutOfBounds(Face),  5=OutOfBounds(Jake),   6=OutOfBounds(Undying)
            //
            Undying = new Mascot(2, 6, Mascot.moveTimer, Mascot.killTimer);
            Jake = new Mascot(1, 5, Mascot.moveTimer, Mascot.killTimer);
            TheFace = new Mascot(1, 4, Mascot.moveTimer, Mascot.killTimer);
            
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            endTimer++;

           // Undying.move();
            SetUpMascots();
            clockTimer();


        }

        public void clockTimer()

        {
            if (endTimer < 600)
            {
                amTimer.Text = "12am";
            }

            if (endTimer >= 600 && endTimer <= 1200)
            {
                amTimer.Text = "1am";
            }


            else if (endTimer > 1200 && endTimer <= 1800)
            {
                amTimer.Text = "2am";
            }

            else if (endTimer > 1800 && endTimer <= 2400)
            {
                amTimer.Text = "3am";
            }

            else if (endTimer > 2400 && endTimer <= 3000)
            {
                amTimer.Text = "4am";
            }

            else if (endTimer > 3000 && endTimer <= 3600)
            {
                amTimer.Text = "5am";
            }

            else if (endTimer == 4200)
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
