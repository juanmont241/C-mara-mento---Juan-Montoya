using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Câmara_mento___Juan_Montoya
{
    internal class Mascot
    {
        Random randGen = new Random(); //Declaring the Random Genrator
        
        public static int attackType;
        public static int currentPostion;
        public static int moveTimer;
        public static int killTimer;

        public Mascot(int _attackType, int _currentPostion, int _moveTimer, int _killTimer)
        {
            attackType = _attackType;
            currentPostion = _currentPostion;
            moveTimer = _moveTimer;
            killTimer = _killTimer;
        }

        public void move(int currentPosition)
        {
            moveTimer--;

            //
            // Current Postions:  0=Office,  1=Char Prep,   2=Roof,   3=Locker,   4=OutOfBounds(Face),  5=OutOfBounds(Jake),   6=OutOfBounds(Undying)
            //

            //----------The Face's Postions-------------//

            if (currentPostion == 4 && moveTimer == 0)
            {
                //RoofScreen.FaceCam.Visible = true;
                currentPostion = 2;
                ResetMovement();
         
            }

            else if (currentPostion == 2 && moveTimer == 0)
            {
                //RoofScreen.FaceCam.Visible = false;
                //OfficeScreen.FaceOffice.Visible = true;
                currentPosition = 0;
                ResetMovement();

            }
        }

        public void kill(int killTimer, int attackType, UserControl uc) //<<-- Make 3 diffrent move methods and kill methods for each suit so usercontrol works
        {
            killTimer--;

            if (attackType == 1)
            {
               if (OfficeScreen.CameraClicked == 1)
                {
                    uc.Visible = false;
                    //OfficeScreen.JakeOffice.Visible = false;
                    ResetMovement();
                    OfficeScreen.TheFaceInOffice = 0;
                    OfficeScreen.JakeInOffice = 0;
                }

               else
                {
                    if (killTimer == 0 && OfficeScreen.TheFaceInOffice == 1)
                    {
                        Form1.ChangeScreen(this, new GameOverScreen());

                    }

                    else if (killTimer == 0 && OfficeScreen.JakeInOffice == 1)
                    {
                        Form1.ChangeScreen(this, new GameOverScreen());
                    }
                }
            }

            else if (attackType == 2)
            {
                if (OfficeScreen.HidingTable == 1)
                {
                    //OfficeScreen.UndyingOffice.Visible = false;
                    ResetMovement();
                }

                else if (killTimer == 0 && OfficeScreen.UndyingInOffice == 1)
                {
                    Form1.ChangeScreen(this, new GameOverScreen());
                }
            }
        }

        public void ResetMovement()
        {
            if (GameMenuScreen.Difficulty == 1)
            {
                moveTimer = randGen.Next(800, 1000);
            }

            else if (GameMenuScreen.Difficulty == 2)
            {
                moveTimer = randGen.Next(500, 700);
            }

            else if (GameMenuScreen.Difficulty == 3)
            {
                moveTimer = randGen.Next(300, 500);
            }
        }






    }
}
