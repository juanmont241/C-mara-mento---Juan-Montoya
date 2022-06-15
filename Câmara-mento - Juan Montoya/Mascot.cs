using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        void move(int currentPosition, OfficeScreen m)
        {
            moveTimer--;

            //
            // Current Postions:  0=Office,  1=Char Prep,   2=Roof,   3=Locker,   4=OutOfBounds(Face),  5=OutOfBounds(Jake),   6=OutOfBounds(Undying)
            //

            //----------The Face's Postions-------------//

            if (currentPostion == 4 && moveTimer == 0)
            {
                RoofScreen.FaceCam.Visible = true;
                currentPostion = 2;
                
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

            else if (currentPostion == 2 && moveTimer == 0)
            {
                RoofScreen.FaceCam.Visible = false;
                OfficeScreen.FaceOffice.Visible = true;
                currentPosition = 0;
            }
        }

       void boolean kill(int killTimer, OfficeScreen k)
        {
            if (killTimer == 0)
            {

            }
        }




    }
}
