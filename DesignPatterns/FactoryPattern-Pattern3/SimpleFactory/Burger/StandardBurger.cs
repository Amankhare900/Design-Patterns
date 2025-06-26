namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.SimpleFactory.Burger;

public class StandardBurger : IBurger
{
  public void Prepare()
  {
    Console.WriteLine("Preparing Standard Burger with bun, patty, cheese, and lettuce!");
  }
}