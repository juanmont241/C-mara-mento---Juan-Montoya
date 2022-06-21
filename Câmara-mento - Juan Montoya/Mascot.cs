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

        void ResetMovement()
        {
            if (GameMenuScreen.Difficulty == 1)
            {
                Mascot.moveTimer = randGen.Next(800, 1000);
                Mascot.killTimer = randGen.Next(800, 1000);
            }

            else if (GameMenuScreen.Difficulty == 2) {
                Mascot.moveTimer = randGen.Next(500, 700);
                Mascot.killTimer = randGen.Next(400, 600);
            }

            else if (GameMenuScreen.Difficulty == 3)
            {
                Mascot.moveTimer = randGen.Next(300, 500);
                Mascot.killTimer = randGen.Next(300, 500);
            }

            else if (GameMenuScreen.Difficulty == 4)
            {
                Mascot.moveTimer = randGen.Next(300, 500);
                Mascot.killTimer = randGen.Next(300, 500);
            }
        }

        public void moveTheFace(int currentPosition, UserControl uc)
        {
            moveTimer--;

            //
            // Current Postions:  0=Office,  1=Char Prep,   2=Roof,   3=Locker,   4=OutOfBounds(Face),  5=OutOfBounds(Jake),   6=OutOfBounds(Undying)
            //

            //----------The Face's Postions-------------//

            if (currentPostion == 4 && moveTimer == 0)
            {
                uc.Visible = true; //Roofscreen
                currentPostion = 2;
                ResetMovement();

            }

            else if (currentPostion == 2 && moveTimer == 0)
            {
                uc.Visible = false; //Roofscreen
                uc.Visible = true; //Officescreen
                currentPosition = 0;
                OfficeScreen.TheFaceInOffice = 1;
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
                    ResetMovement();
                    OfficeScreen.TheFaceInOffice = 0;
                    currentPostion = 6;

                }

                else if (attackType == 2)
                {
                    if (OfficeScreen.CameraClicked == 1)
                    {
                        uc.Visible = false;
                        ResetMovement();
                        OfficeScreen.JakeInOffice = 0;
                        currentPostion = 5;
                    }

                    else
                    {
                        if (killTimer == 0 && OfficeScreen.TheFaceInOffice == 1)
                        {
                            Form1.ChangeScreen(this, new GameOverScreen());

                        if (killTimer == 0 && OfficeScreen.TheFaceInOffice == 1 && GameMenuScreen.normalGame == 0)
                            {
                                Form1.ChangeScreen(this, new HighScoreScreen());
                            }

                        }

                        else if (killTimer == 0 && OfficeScreen.JakeInOffice == 1)
                        {
                            Form1.ChangeScreen(this, new GameOverScreen());
                        }

                        if (killTimer == 0 && OfficeScreen.JakeInOffice == 1 && GameMenuScreen.normalGame == 0)
                        {
                            Form1.ChangeScreen(this, new HighScoreScreen());
                        }



                        else if (attackType == 3)
                        {
                            if (OfficeScreen.HidingTable == 1)
                            {
                                uc.Visible = false;
                                ResetMovement();
                            }

                            else if (killTimer == 0 && OfficeScreen.UndyingInOffice == 1)
                            {
                                Form1.ChangeScreen(this, new GameOverScreen());
                            }

                            else if (killTimer == 0 && OfficeScreen.UndyingInOffice == 1 && GameMenuScreen.normalGame == 0)
                            {
                                Form1.ChangeScreen(this, new HighScoreScreen());
                            }

                        }

                    }
                }
            }
        }
    }
}
