using PRACTICEPATTERN.DesignPatterns.Pattern1.Behavior.Fly;
using PRACTICEPATTERN.DesignPatterns.Pattern1.Behavior.Quack;

namespace PRACTICEPATTERN.DesignPatterns.Pattern1.Duck;

public class RubberDuck : Duck
{
  public RubberDuck()
  {
    quackBehavior = new MuteQuack();
    flyBehavior = new FlyNoWay();
  }

  public override void Display()
  {
    
  }
}