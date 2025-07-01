using PRACTICEPATTERN.DesignPatterns.ObserverPattern.Observer;
using PRACTICEPATTERN.DesignPatterns.ObserverPattern.Subject;

namespace PRACTICEPATTERN.DesignPatterns.ObserverPattern.Display;

public class StatisticsDisplay : IObserver, IDisplayElement
{
  private double MinTemperature { get; set; }

  private double MaxTemperature { get; set; }

  private double TemperatureSum { get; set; }
  private int NumReadings { get; set; }

  private WeatherData _weatherData;

  public StatisticsDisplay(WeatherData weatherData)
  {
    _weatherData = weatherData;
    _weatherData.RegisterObserver(this);
  }

  public void Display()
  {
    Console.WriteLine("Avg/Max/Min temperature = " + (TemperatureSum / NumReadings)
      + "/" + MaxTemperature + "/" + MinTemperature);
  }

  public void Update(double temp, double humidity, double pressure)
  {
    TemperatureSum += temp;
    NumReadings++;

    if (temp > MaxTemperature)
    {
      MaxTemperature = temp;
    }

    if (temp < MinTemperature)
    {
      MinTemperature = temp;
    }
    Display();
  }
  public void Update()
  {
    double temp = _weatherData.Temperature;
    TemperatureSum += temp;
		NumReadings++;

		if (temp > MaxTemperature) {
			MaxTemperature = temp;
		}
 
		if (MinTemperature == 0 || temp < MinTemperature) {
			MinTemperature = temp;
		}
    Display();
  }

}