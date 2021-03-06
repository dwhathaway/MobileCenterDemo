﻿using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace MobileCenterDemo.UITests
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
				return ConfigureApp.Android.ApkFile("../../../../MobileCenterDemo/Droid/bin/debug/com.xamarin.mobilecenterdemo.apk").StartApp();
			}

			return ConfigureApp.iOS.StartApp();
		}
	}
}
