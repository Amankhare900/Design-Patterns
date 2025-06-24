using PRACTICEPATTERN.DesignPatterns.Pattern1.StrategyPatternChallenge.Media;

namespace PRACTICEPATTERN.DesignPatterns.Pattern1.StrategyPatternChallenge.Camera;

public abstract class PhoneCameraApp {
	IShareStrategy ShareStrategy;
	
	public void SetShareStrategy(IShareStrategy shareStrategy) {
		this.ShareStrategy = shareStrategy;
	}
	public void Share() {
		ShareStrategy.Share();
	}
	public void Take() {
		Console.WriteLine("Taking the photo");
	}
	public void Save() {
		Console.WriteLine("Saving the photo");
	}
	public abstract void Edit();
}
