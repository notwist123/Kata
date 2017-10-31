using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class ConwayGame
    {
        private EnumStatus _status;
        private int _aliveNumberAround;

        public ConwayGame(EnumStatus status, int number)
        {
            _status = status;
            _aliveNumberAround = number;
        }

        public EnumStatus GetNextStatus()
        {
            if (_status == EnumStatus.Alive)
            {
                return _aliveNumberAround > 3
                    ? EnumStatus.Dead
                    : _aliveNumberAround < 2
                        ? EnumStatus.Dead
                        : EnumStatus.Alive;
            }
            return _aliveNumberAround == 3 ? EnumStatus.Alive : EnumStatus.Dead;
        }
    }
}
