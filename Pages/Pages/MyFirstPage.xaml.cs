using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Pages
{
	public partial class MyFirstPage : ContentPage
	{
		public MyFirstPage()
		{
			InitializeComponent();
		}

		public void OnClicked(Object sender, EventArgs e)
		{
			Navigation.PushAsync(new MySecondPage());
		}
	}
}

