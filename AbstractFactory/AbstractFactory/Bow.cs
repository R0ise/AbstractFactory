using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Bow : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Лучник выстреливает из лука");
        }
    }
}
