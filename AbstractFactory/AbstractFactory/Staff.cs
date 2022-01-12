using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Staff : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Маг использует волшебный посох");
        }
    }
}
