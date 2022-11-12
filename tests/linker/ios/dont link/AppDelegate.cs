#if !__WATCHOS__
using System;
using System.Reflection;
using Foundation;
using UIKit;
using MonoTouch.NUnit.UI;

namespace DontLink
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		static public TouchRunner Runner { get; private set; }

		public override UIWindow Window { get; set; }

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
#if __MACCATALYST__
			// Debug spew to track down https://github.com/xamarin/maccore/issues/2414
			Console.WriteLine ("AppDelegate.FinishedLaunching");
#endif
			// create a new window instance based on the screen size
			Window = new UIWindow (UIScreen.MainScreen.Bounds);
			Runner = new TouchRunner (Window);

			// tests can be inside the main assembly
			Runner.Add (Assembly.GetExecutingAssembly ());
			Runner.Add (typeof (BundledResources.ResourcesTest).Assembly);

			Window.RootViewController = new UINavigationController (Runner.GetViewController ());
			
			// make the window visible
			Window.MakeKeyAndVisible ();
			
			return true;
		}

		static void Main (string[] args)
		{
			UIApplication.Main (args, null, typeof (AppDelegate));
		}
	}
}
#endif // !__WATCHOS__
