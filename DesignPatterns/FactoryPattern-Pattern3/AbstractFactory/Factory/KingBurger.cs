using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Burger;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Factory;

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