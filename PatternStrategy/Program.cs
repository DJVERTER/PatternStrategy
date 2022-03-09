using PatternStrategy;
using PatternStrategy.Strategies;
using System;

Herro hero = new("Squidward");

hero.Attack();

hero.SetWeapon(new Broom());

hero.Attack();

hero.SetWeapon(new Plunger());

hero.Attack();

hero.SetWeapon(new WaterGun());

hero.Attack();

Console.ReadLine();
