namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Burger;

public class BasicBurger : IBurger
{
  public void Prepare()
  {
    Console.WriteLine("Preparing Basic Burger with bun, patty, and ketchup!");
  }
}