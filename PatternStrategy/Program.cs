using System;
using PatternStrategy;
using PatternStrategy.Strategies;

Herro hero = new("Squidward");

hero.Attack();

hero.SetWeapon(new Broom());

hero.Attack();

hero.SetWeapon(new Plunger());

hero.Attack();

Console.ReadLine();
