using PRACTICEPATTERN.DesignPatterns.ObserverPattern.Display;
using PRACTICEPATTERN.DesignPatterns.ObserverPattern.Subject;

namespace PRACTICEPATTERN.DesignPatterns.ObserverPattern;
public class WeatherStation
{
  public static void StartWeatherStation()
  {
    WeatherData weatherData = new();
    CurrentConditionsDisplay currentDisplay = new(weatherData);
    StatisticsDisplay statisticsDisplay = new(weatherData);
    ForecastDisplay forecastDisplay = new(weatherData);
    HeatIndexDisplay heatIndexDisplay = new(weatherData);

    weatherData.SetMeasurements(80, 65, 30.4f);
    weatherData.SetMeasurements(82, 70, 29.2f);
    weatherData.SetMeasurements(78, 90, 29.2f);
  }
}