using System;

using Xamarin.Forms;

namespace Pages
{
	public class masterPage : ContentPage
	{
		public masterPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

