
using RPG.src.Entities.Hero;
namespace RPG.src.Entities
{
  public class Wizard : Hero
  {
    public Wizard(string name, int level, string herotype)
    {
      this.Name = name;
      this.Level = level;
      this.HeroType = herotype;
    }
    public override string Attack()
    {
      return this.Name + " lançou magia";
    }

    public string Attack(int bonus)
    {
      return this.Name + " Lançou magia com bonus de ataque de " + bonus;
    }
  }
}