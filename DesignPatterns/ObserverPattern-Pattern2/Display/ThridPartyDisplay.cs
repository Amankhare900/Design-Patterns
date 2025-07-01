using PRACTICEPATTERN.DesignPatterns.ObserverPattern.Observer;
using PRACTICEPATTERN.DesignPatterns.ObserverPattern.Subject;

namespace PRACTICEPATTERN.DesignPatterns.ObserverPattern.Display;

public class ThirdPartyDisplay : IObserver, IDisplayElement
{
  public double Temperature { get; set; }

  public double Humidity { get; set; }

  public double Pressure { get; set; }
  public readonly WeatherData _weatherData;

  public ThirdPartyDisplay(WeatherData weatherData) {
    _weatherData = weatherData;
    _weatherData.RegisterObserver(this);
  }
  public void Display()
  {
    Console.WriteLine("ThirdPartyDisplay:- Current conditions: " + Temperature + "F degrees and " + Humidity + "% humidity");
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