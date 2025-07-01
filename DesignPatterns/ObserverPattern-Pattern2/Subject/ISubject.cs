using PRACTICEPATTERN.DesignPatterns.ObserverPattern.Observer;

namespace PRACTICEPATTERN.DesignPatterns.ObserverPattern.Subject;

public interface ISubject
{
  public void RegisterObserver(IObserver o);
  public void RemoveObserver(IObserver o);
  public void NotifyObserver();
}