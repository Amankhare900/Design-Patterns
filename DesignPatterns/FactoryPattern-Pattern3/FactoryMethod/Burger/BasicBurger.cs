namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.FactoryMethod.Burger;

public class BasicBurger : IBurger
{
  public void Prepare()
  {
    Console.WriteLine("Preparing Basic Burger with bun, patty, and ketchup!");
  }
}