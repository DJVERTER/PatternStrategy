using System;

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
