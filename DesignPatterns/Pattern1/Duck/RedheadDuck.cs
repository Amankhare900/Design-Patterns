using PRACTICEPATTERN.DesignPatterns.Pattern1.Behavior.Fly;
using PRACTICEPATTERN.DesignPatterns.Pattern1.Behavior.Quack;

namespace PRACTICEPATTERN.DesignPatterns.Pattern1.Duck;

public class RedheadDuck : Duck
{
  public RedheadDuck()
  {
    quackBehavior = new MuteQuack();
    flyBehavior = new FlyWithWings();
  }

  public override void Display()
  {
    
  }
}