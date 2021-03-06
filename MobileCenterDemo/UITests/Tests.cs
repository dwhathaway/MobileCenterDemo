﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace MobileCenterDemo.UITests
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
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void WelcomeTextIsDisplayed()
		{
			app.WaitForElement(c => c.Marked("myButton"));

			app.Screenshot("First Screen");

			app.Tap(x => x.Marked("myButton"));

			AppResult[] results = app.WaitForElement(x => x.Marked("Hello, Mobile Center!"));

			Assert.IsTrue(results.Any());
		}
	}
}
