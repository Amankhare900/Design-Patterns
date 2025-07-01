using PRACTICEPATTERN.DesignPatterns.ObserverPattern.Observer;
using PRACTICEPATTERN.DesignPatterns.ObserverPattern.Subject;

namespace PRACTICEPATTERN.DesignPatterns.ObserverPattern.Display;

public class ForecastDisplay: IObserver, IDisplayElement {
	private double CurrentPressure = 29.92f;  
	private double LastPressure;
	private WeatherData _weatherData;

	public ForecastDisplay(WeatherData weatherData) {
		_weatherData = weatherData;
		weatherData.RegisterObserver(this);
	}

	public void Update(double temp, double humidity, double pressure) {
		LastPressure = CurrentPressure;
		CurrentPressure = pressure;

		Display();
	}

	public void Update() {
		LastPressure = CurrentPressure;
		CurrentPressure = _weatherData.Pressure;
		Display();
	}

	
	public void Display()
	{
		Console.Write("Forecast: ");
		if (CurrentPressure > LastPressure)
		{
			Console.Write("Improving weather on the way!");
		}
		else if (CurrentPressure == LastPressure)
		{
			Console.Write("More of the same");
		}
		else if (CurrentPressure < LastPressure)
		{
			Console.Write("Watch out for cooler, rainy weather");
		}
	}
}
