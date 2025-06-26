namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Burger;
public class PremiumWheatBurger : IBurger
{
  public void Prepare()
  {
    Console.WriteLine("Preparing Premium Wheat Burger with Wheat bun, premium patty, cheese, lettuce, and secret sauce!");
  }
}