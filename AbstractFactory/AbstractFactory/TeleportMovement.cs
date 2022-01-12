using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // движение телепорт
    class Teleport : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Маг телепортируется");
        }
    }
}
