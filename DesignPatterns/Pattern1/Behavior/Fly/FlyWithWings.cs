namespace PRACTICEPATTERN.DesignPatterns.Pattern1.Behavior.Fly;

public class FlyWithWings:IFlyBehavior
{
  void IFlyBehavior.Fly()
  {
    Console.WriteLine("I'm flying!!");
  }
}