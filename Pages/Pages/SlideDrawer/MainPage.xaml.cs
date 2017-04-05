using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Pages
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();

			MasterPage.ListView.ItemSelected += OnItemSelected;
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;

			if (item != null)
			{
				Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
				MasterPage.ListView.SelectedItem = null;
				IsPresented = false;
			}
		}
	}
}
