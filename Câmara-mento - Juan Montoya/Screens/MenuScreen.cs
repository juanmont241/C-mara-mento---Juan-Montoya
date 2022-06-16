using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;
using System.Media;

namespace Câmara_mento___Juan_Montoya
{
    public partial class MenuScreen : UserControl
    {

        public static List<SoundPlayer> gameSoundList = new List<SoundPlayer>(); //List to store all sounds

        public MenuScreen()
        {
            InitializeComponent();
            SoundList();
        }

        public void SoundList()
        {
            SoundPlayer CameraChange = new SoundPlayer(Properties.Resources.Camchange);
            SoundPlayer PickUpCamera = new SoundPlayer(Properties.Resources.Pickupcam);
            SoundPlayer ShutOffCamera = new SoundPlayer(Properties.Resources.CAMOFF);
            SoundPlayer HideTable = new SoundPlayer(Properties.Resources.TableDown);
            SoundPlayer UnHideTable = new SoundPlayer(Properties.Resources.TableUp);
            SoundPlayer FinishedNight = new SoundPlayer(Properties.Resources._6am);
            

            gameSoundList.Add(CameraChange); //0
            gameSoundList.Add(PickUpCamera); //1
            gameSoundList.Add(ShutOffCamera); //2
            gameSoundList.Add(HideTable); //3
            gameSoundList.Add(UnHideTable); //4
            gameSoundList.Add(FinishedNight); //5

        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameLabel_Click(object sender, EventArgs e)
        {
            gameSoundList[0].Play(); //Plays Camera Switch sound
            Form1.ChangeScreen(this, new GameMenuScreen());
        }

        private void howToPlayLabel_Click(object sender, EventArgs e)
        {
            gameSoundList[0].Play(); // Plays Camera Switch sound
            Form1.ChangeScreen(this, new HowToPlayScreen());
        }
    }
}
