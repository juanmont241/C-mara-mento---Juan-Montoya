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
    public partial class MascotScreen : UserControl
    {
        public MascotScreen()
        {
            InitializeComponent();
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            MenuScreen.gameSoundList[0].Play(); // Plays Camera Swtich sound
            Form1.ChangeScreen(this, new HowToPlayScreen());
        }

        private void TransitionTimer_Tick(object sender, EventArgs e)
        {
            Transition.Visible = false;
        }
    }
}
