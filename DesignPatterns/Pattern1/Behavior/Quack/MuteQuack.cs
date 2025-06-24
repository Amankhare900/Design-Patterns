namespace PRACTICEPATTERN.DesignPatterns.Pattern1.Behavior.Quack;

public class MuteQuack : IQuackBehavior
{
  void IQuackBehavior.Quack()
  {
    Console.WriteLine("...");
  }
}