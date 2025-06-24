using PRACTICEPATTERN.DesignPatterns.Pattern1.Duck;

public class MiniDuckSimulator
{
  public static void DuckPatter()
  {
    MallardDuck mallard = new();
    mallard.PerformFly();
    mallard.PerformQuack();

    RubberDuck rubber = new();
    rubber.PerformFly();
    rubber.PerformQuack();


    RedheadDuck redhead = new();
    redhead.PerformFly();
    redhead.PerformQuack();
  }
}