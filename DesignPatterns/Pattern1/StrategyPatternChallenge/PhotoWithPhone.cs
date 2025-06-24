using PRACTICEPATTERN.DesignPatterns.Pattern1.StrategyPatternChallenge.Camera;
using PRACTICEPATTERN.DesignPatterns.Pattern1.StrategyPatternChallenge.Media;

namespace PRACTICEPATTERN.DesignPatterns.Pattern1.StrategyPatternChallenge;


public class PhotoWithPhone {
	public static void UsePhone() {
 
		PhoneCameraApp cameraApp = new BasicCameraApp();
		string share = GetSharing();
		switch (share) {
			case("t"): cameraApp.SetShareStrategy(new Txt()); break;
			case("e"): cameraApp.SetShareStrategy(new Email()); break;
			case("s"): cameraApp.SetShareStrategy(new Social()); break;
			default: cameraApp.SetShareStrategy(new Txt()); break;
		}
		cameraApp.Take();
		cameraApp.Edit();
		cameraApp.Save();
		cameraApp.Share();
	}
	public static string GetSharing() {
		Console.WriteLine("Share with txt (t), email (e), or social media (s)?");
		string appName = Console.ReadLine() ?? "";
		return appName;
	}
}
