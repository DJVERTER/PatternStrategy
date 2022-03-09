using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Strategies
{
    class Plunger : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("attacks with plunger");
        }
    }
}
