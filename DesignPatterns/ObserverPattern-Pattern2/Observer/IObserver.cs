namespace PRACTICEPATTERN.DesignPatterns.ObserverPattern.Observer;

public interface IObserver
{
  public void Update(double temp, double humidity, double pressure);
  public void Update();
}