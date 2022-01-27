using System;
using RPG.src.Entities.Hero;

namespace RPG
{
  class Program
  {
    static void Main(string[] args)
    {
      Hero hero = new Hero("André", 1, "Knight");
      Wizard wizard = new Wizard("Jennica", 1, "Wizard");

      Console.WriteLine(wizard.Attack());

      Console.WriteLine(hero.Attack());
    }
  }
}
