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
    public partial class _6amScreen : UserControl
    {
        public _6amScreen()
        {
            MenuScreen.gameSoundList[5].Play(); //Plays 6am sound
            InitializeComponent();
        }

        private void _6amTimer_Tick(object sender, EventArgs e)
        {
            _6am.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
