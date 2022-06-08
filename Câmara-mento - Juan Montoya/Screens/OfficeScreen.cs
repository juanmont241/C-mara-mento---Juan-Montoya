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
            CamUp.Visible = true;

            Thread(1000);

            //CameraWaitScreen cws = new CameraWaitScreen();
            //Form form = this.FindForm();

            //form.Controls.Add(cws);
            //form.Controls.Remove(this);

            //cws.Location = new Point((form.Width - cws.Width) / 2, (form.Height - cws.Height) / 2);

            //CamDown.Visible = true;
        }

    }
}
