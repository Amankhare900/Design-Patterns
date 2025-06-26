using PRACTICEPATTERN.DesignPatterns.FactoryPattern.SimpleFactory.Burger;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.SimpleFactory.Factory;

public class BurgerFactory
{
  public static IBurger CreateBurger(string type)
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