using System;
using MonoTouch.Foundation;

namespace XamarinStore
{
	public static class TranslateExtensions
	{
		public static string t(this string translate)
		{
			return NSBundle.MainBundle.LocalizedString(translate, "", "");
		}
	}
}