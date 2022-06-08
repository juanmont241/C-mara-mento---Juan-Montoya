using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Câmara_mento___Juan_Montoya
{
    internal class Mascot
    {
        public string attackType;

        public string currentPostion;

        public int moveTimer;

        public int killTimer;

        public Mascot(string _attackType, string _currentPostion, int _moveTimer, int _killTimer)
        {
            _attackType = _attackType;
            _currentPostion = _currentPostion;
            _moveTimer = _moveTimer;
            _killTimer = _killTimer;
        }

        void move(string moveTimer, OfficeScreen m)
        {

        }

        //boolean kill(int killTimer, OfficeScreen k)
        //{

        //}

        //boolean defense(string attackType, OfficeScreen a)
        //{

        //}



    }
}
