using PRACTICEPATTERN.DesignPatterns.Pattern1.Behavior.Fly;
using PRACTICEPATTERN.DesignPatterns.Pattern1.Behavior.Quack;

namespace PRACTICEPATTERN.DesignPatterns.Pattern1.Duck;

public abstract class Duck
{
  internal IFlyBehavior? flyBehavior;
  internal IQuackBehavior? quackBehavior;

  public void PerformQuack()
  {
    flyBehavior?.Fly();
  }

  public void PerformFly()
  {
    quackBehavior?.Quack();
  }

  public void SetFlyBehavior(IFlyBehavior fb) {
 flyBehavior = fb;
}
public void SetQuackBehavior(IQuackBehavior qb) {
 quackBehavior = qb;
}

  public abstract void Display();
}