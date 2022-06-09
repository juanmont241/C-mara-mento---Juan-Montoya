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
        public OfficeScreen()
        {
            InitializeComponent();
            
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
           
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
           // camDown.Visible = false;
        }
    }
}
