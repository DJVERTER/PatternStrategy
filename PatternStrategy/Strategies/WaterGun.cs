using System;

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
