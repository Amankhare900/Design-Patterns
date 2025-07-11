using PRACTICEPATTERN.DesignPatterns.FactoryPattern.FactoryMethod.Burger;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.FactoryMethod.Factory;

public class SinghBurger : IBurgerFactory
{
  public IBurger CreateBurger(string type)
  {
    if (type == "basic")
    {
      return new BasicWheatBurger();
    }
    else if (type == "standard")
    {
      return new StandardWheatBurger();
    }
    else if (type == "premium")
    {
      return new PremiumWheatBurger();
    }
    else
    {
      Console.WriteLine("Invalid burger type!");
      return null;
    }
  }
}