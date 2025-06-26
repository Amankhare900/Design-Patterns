namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.FactoryMethod.Burger;

public class PremiumBurger : IBurger
{
  public void Prepare()
  {
    Console.WriteLine("Preparing Premium Burger with bun, premium patty, cheese, lettuce, and secret sauce!");
  }
}