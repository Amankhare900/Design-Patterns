namespace PRACTICEPATTERN.DesignPatterns.Pattern1.Behavior.Fly;

public class FlyNoWay : IFlyBehavior
{
  void IFlyBehavior.Fly()
  {
    Console.WriteLine("Can't fly!");
  }
}