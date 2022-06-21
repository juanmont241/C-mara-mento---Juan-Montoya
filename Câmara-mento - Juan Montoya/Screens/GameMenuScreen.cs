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
        Random randGen = new Random(); //Declaring the Random Genrator
        public static int Difficulty, normalGame = 1, SurviorTimer;

        public GameMenuScreen()
        {
            InitializeComponent();
        }

        private void easyLabel_Click(object sender, EventArgs e)
        {
            MenuScreen.gameSoundList[0].Play(); // Plays Camera Swtich sound
            Form1.ChangeScreen(this, new OfficeScreen());

            Mascot.moveTimer = randGen.Next(800, 1000);
            Mascot.killTimer = randGen.Next(800, 1000);
            Difficulty = 1;
        }

        private void mediumLabel_Click(object sender, EventArgs e)
        {
            MenuScreen.gameSoundList[0].Play(); // Plays Camera Swtich sound
            Form1.ChangeScreen(this, new OfficeScreen());

            Mascot.moveTimer = randGen.Next(500, 700);
            Mascot.killTimer = randGen.Next(400, 600);
            Difficulty = 2;
        }

        private void hardLabel_Click(object sender, EventArgs e)
        {
            MenuScreen.gameSoundList[0].Play(); // Plays Camera Swtich sound
            Form1.ChangeScreen(this, new OfficeScreen());

            Mascot.moveTimer = randGen.Next(100, 200);
            Mascot.killTimer = randGen.Next(200, 300);
            Difficulty = 3;

        }

        private void endlessLabel_Click(object sender, EventArgs e)
        {
            MenuScreen.gameSoundList[0].Play(); // Plays Camera Swtich sound
            Form1.ChangeScreen(this, new OfficeScreen());

            Difficulty = 4;
            normalGame = 0;

        }

        private void backhtpLabel_Click(object sender, EventArgs e)
        {
            MenuScreen.gameSoundList[0].Play(); // Plays Camera Swtich sound
            MenuScreen ms = new MenuScreen();
            Form form = this.FindForm();

            form.Controls.Add(ms);
            form.Controls.Remove(this);

            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
        }
    }
}
