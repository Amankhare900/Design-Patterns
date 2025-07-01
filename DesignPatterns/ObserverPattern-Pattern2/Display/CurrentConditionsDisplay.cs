using PRACTICEPATTERN.DesignPatterns.ObserverPattern.Observer;
using PRACTICEPATTERN.DesignPatterns.ObserverPattern.Subject;

namespace PRACTICEPATTERN.DesignPatterns.ObserverPattern.Display;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
  public double Temperature { get; set; }

  public double Humidity { get; set; }

  public double Pressure { get; set; }

  private WeatherData _weatherData;

  public CurrentConditionsDisplay(WeatherData weatherData)
  {
    _weatherData = weatherData;
    weatherData.RegisterObserver(this);
  }

  public void Display()
  {
    Console.WriteLine("Current conditions: " + Temperature + "F degrees and " + Humidity + "% humidity");
  }

  public void Update(double temp, double humidity, double pressure)
  {
    Temperature = temp;
    Humidity = humidity;
    Pressure = pressure;
    Display();
  }
  
  public void Update()
  {
    Temperature = _weatherData.Temperature;
    Humidity = _weatherData.Humidity;
    Pressure = _weatherData.Pressure;
    Display();
  }

}