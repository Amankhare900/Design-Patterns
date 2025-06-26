using PRACTICEPATTERN.DesignPatterns.FactoryPattern.FactoryMethod.Burger;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.FactoryMethod.Factory;

public class KingBurger : IBurgerFactory
{
  public IBurger CreateBurger(string type)
  {
    if (type == "basic")
    {
      return new BasicBurger();
    }
    else if (type == "standard")
    {
      return new StandardBurger();
    }
    else if (type == "premium")
    {
      return new PremiumBurger();
    }
    else
    {
      Console.WriteLine("Invalid burger type!");
      return null;
    }
  }
}