using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Câmara_mento___Juan_Montoya
{
    internal class Mascot
    {
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

            //----------The Face Postions-------------//

             if (currentPostion == 4 && moveTimer == 0)
            {
                RoofScreen.FaceCam.Visible = true;
                currentPostion = 2;
                
                if (GameMenuScreen.Difficulty == 1)
                {

                }

                else if (GameMenuScreen.Difficulty == 2)
                {

                }

                else if (GameMenuScreen.Difficulty == 3)
                {

                }
            }
        }

        //boolean kill(int killTimer, OfficeScreen k)
        //{

        //}

        //boolean defense(string attackType, OfficeScreen a)
        //{

        //}



    }
}
