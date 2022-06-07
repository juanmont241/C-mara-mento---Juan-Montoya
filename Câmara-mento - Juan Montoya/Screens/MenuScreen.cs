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
            GameMenuScreen ng = new GameMenuScreen();
            Form form = this.FindForm();

            form.Controls.Add(ng);
            form.Controls.Remove(this);

            ng.Location = new Point((form.Width - ng.Width) / 2, (form.Height - ng.Height) / 2);
        }

        private void howToPlayLabel_Click(object sender, EventArgs e)
        {
            HowToPlayScreen gs = new HowToPlayScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
        }
    }
}
