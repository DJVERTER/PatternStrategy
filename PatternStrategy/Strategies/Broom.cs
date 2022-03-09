using System;

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
