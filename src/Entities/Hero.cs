namespace RPG.src.Entities
{
  public class Arus
  {
    public Arus(string name, int level, string herotype)
    {
      this.Name = name;
      this.Level = level;
      this.HeroType = herotype;
    }

    public Arus()
    {

    }

    public string Name;
    public int Level;
    public string HeroType;

    public override string ToString()
    {
      return this.Name + " " + this.Level + " " + this.HeroType;
    }
  }
}