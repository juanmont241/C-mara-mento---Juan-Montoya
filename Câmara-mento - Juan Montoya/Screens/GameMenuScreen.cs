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
    public partial class GameMenuScreen : UserControl
    {
        public GameMenuScreen()
        {
            InitializeComponent();
        }

        private void easyLabel_Click(object sender, EventArgs e)
        {
            OfficeScreen os = new OfficeScreen();
            Form form = this.FindForm();

            form.Controls.Add(os);
            form.Controls.Remove(this);

            os.Location = new Point((form.Width - os.Width) / 2, (form.Height - os.Height) / 2);
        }

        private void mediumLabel_Click(object sender, EventArgs e)
        {

        }

        private void hardLabel_Click(object sender, EventArgs e)
        {

        }

        private void endlessLabel_Click(object sender, EventArgs e)
        {

        }

        private void backhtpLabel_Click(object sender, EventArgs e)
        {
            MenuScreen ms = new MenuScreen();
            Form form = this.FindForm();

            form.Controls.Add(ms);
            form.Controls.Remove(this);

            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
        }
    }
}
