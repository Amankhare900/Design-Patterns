using System.Dynamic;
using PRACTICEPATTERN.DesignPatterns.ObserverPattern.Observer;

namespace PRACTICEPATTERN.DesignPatterns.ObserverPattern.Subject;

public class WeatherData : ISubject
{
  public ISet<IObserver> _observer { get; set; }

  public double Temperature { get; set; }

  public double Humidity { get; set; }

  public double Pressure { get; set; }

  public WeatherData() => _observer = new HashSet<IObserver>();

  public void RegisterObserver(IObserver o)
  {
    _observer.Add(o);
  }

  public void RemoveObserver(IObserver o)
  {
    _observer.Remove(o);
  }

  public void NotifyObserver()
  {
    foreach (IObserver observer in _observer)
    {
      // observer.Update(Temperature, Humidity, Pressure);
      observer.Update();
    }
  }

  public void MeasurementsChanged()
  {
    NotifyObserver();
  }
  public void SetMeasurements(float temperature, float humidity, float pressure) {
    Temperature = temperature;
    Humidity = humidity;
    Pressure = pressure;
    MeasurementsChanged();
  }
}