namespace PRACTICEPATTERN.DesignPatterns.Pattern1.Behavior.Quack;

public class Quack : IQuackBehavior
{
  void IQuackBehavior.Quack()
  {
    Console.WriteLine("Quacks..");
  }
}