namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.FactoryMethod.Burger;

public class BasicWheatBurger : IBurger
{
  public void Prepare()
  {
    Console.WriteLine("Preparing Basic Wheat Burger with Wheat bun, patty, and ketchup!");
  }
}