using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace TaskyBasic
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			// TODO: If the Android app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			app = ConfigureApp
				.Android
				// TODO: Update this path to point to your Android app and uncomment the
				// code if the app is not included in the solution.
				.ApkFile("/Users/junecho/Desktop/apkS/Tasky.apk")
				.StartApp();
		}

		[Test]
		public void ReplTest()
		{
			app.Repl();
		}

		//This is a basic UI Test using C# and UITest
		[Test]
		public void AndroidAddTaskTest()
		{
			app.Tap(x => x.Id("AddButton"));
			app.Screenshot("Tapped on Add New Task Button");

			app.Tap(x => x.Id("NameText"));
			app.Screenshot("Tapped on Name Field");

			app.EnterText("Feed Kirby");
			app.Screenshot("Typed the name of my Task");
			app.DismissKeyboard();
			app.DismissKeyboard();

			app.Tap(x => x.Id("NotesText"));
			app.Screenshot("Tapped on Notes Field");

			app.EnterText("Kirby runs wild when he is hungry");
			app.Screenshot("Typed my note on Kirby");
			app.DismissKeyboard();
			app.DismissKeyboard();

			app.Tap(x => x.Id("chkDone"));
			app.Screenshot("Clicked on 'Done' Checkbox");

			app.Tap(x => x.Id("SaveButton"));
			app.Screenshot("Tapped on Save Button");
		}

	}
}
