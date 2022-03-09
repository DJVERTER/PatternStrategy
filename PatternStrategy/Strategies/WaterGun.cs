using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Strategies
{
    class WaterGun : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("attacks with water gun");
        }
    }
}
