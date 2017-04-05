using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Pages
{
	public partial class MyNavigationPage : ContentPage
	{
		public MyNavigationPage()
		{
			InitializeComponent();
		}

		async void OnClicked(Object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MyFirstPage());
		}
	}
}
