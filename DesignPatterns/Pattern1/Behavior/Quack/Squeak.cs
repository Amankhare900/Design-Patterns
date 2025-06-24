namespace PRACTICEPATTERN.DesignPatterns.Pattern1.Behavior.Quack;

public class Squeak : IQuackBehavior
{
  void IQuackBehavior.Quack()
  {
    Console.WriteLine("Squeak..");
  }
}