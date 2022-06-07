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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           // FormBorderStyle = FormBorderStyle.None; //Makes the form to fullscreen
           // WindowState = FormWindowState.Maximized;

            ChangeScreen(this, new MenuScreen()); //When the program starts, it instantly changes the screen to the MenuScreen
        }

        public static void ChangeScreen(object sender, UserControl next) //Function code to change from screen to screen
        {
            Form f;
            if (sender is Form)
            {
                f = (Form)sender;
            }
            else
            {
                UserControl current = (UserControl)sender;
                f = current.FindForm();
                f.Controls.Remove(current);
            }

            next.Location = new Point((f.ClientSize.Width - next.Width) / 2, (f.ClientSize.Height - next.Height) / 2);
            f.Controls.Add(next); 
            next.Focus();
        }
    }
}
