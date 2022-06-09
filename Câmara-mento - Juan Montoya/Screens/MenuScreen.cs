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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameLabel_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameMenuScreen());
        }

        private void howToPlayLabel_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new HowToPlayScreen());
        }
    }
}
