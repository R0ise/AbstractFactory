using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Magician : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new Teleport();
        }

        public override Weapon CreateWeapon()
        {
            return new Staff();
        }
    }
}
