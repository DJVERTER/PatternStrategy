using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Strategies
{
    class Broom : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("attacks with broom");
        }
    }
}
