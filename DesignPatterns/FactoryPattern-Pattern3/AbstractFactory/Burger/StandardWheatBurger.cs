namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Burger;

public class StandardWheatBurger : IBurger
{
  public void Prepare()
  {
    Console.WriteLine("Preparing Standard Wheat Burger with Wheat bun, patty, cheese, and lettuce!");
  }
}