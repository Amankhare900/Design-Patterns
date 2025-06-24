using PRACTICEPATTERN.DesignPatterns.Pattern1.Behavior.Fly;
using PRACTICEPATTERN.DesignPatterns.Pattern1.Behavior.Quack;

namespace PRACTICEPATTERN.DesignPatterns.Pattern1.Duck;

public class MallardDuck : Duck
{
  public MallardDuck()
  {
    quackBehavior = new Quack(); // here we are doing program to an implementation which is little bit problem
    flyBehavior = new FlyWithWings();
  }

  public override void Display()
  {
    
  }
}