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
    public partial class CameraWaitScreen : UserControl
    {
        public CameraWaitScreen()
        {
            InitializeComponent();
        }

        private void CamUpTimer_Tick(object sender, EventArgs e)
        {
            CamUp.Visible = false;
        }

        private void cam1_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new LockerScreen());
        }

        private void cam5_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new RoofScreen());
        }

        private void cam2_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new CharPrepScreen());
        }

        private void bringOutCamera_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new OfficeScreen());
        }
    }
}
