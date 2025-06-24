namespace PRACTICEPATTERN.DesignPatterns.Pattern1.StrategyPatternChallenge.Media;

public class Email: IShareStrategy {
  public void Share()
  {
		Console.WriteLine("I'm emailing the photo");
  }

}
