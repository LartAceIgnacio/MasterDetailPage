using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Pages
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }
		IList<MasterPageItem> masterPageItems = new ObservableCollection<MasterPageItem>();

		public MasterPage()
		{
			InitializeComponent();

			BindingContext = masterPageItems;
			masterPageItems.Add(new MasterPageItem()
			{
				Title = "My First Page",
				ImageSource = "icon_sample",
				TargetType = typeof(MyFirstPage)
			});

			masterPageItems.Add(new MasterPageItem()
			{
				Title = "My Second Page",
				ImageSource = "icon_sample",
				TargetType = typeof(MySecondPage)
			});
		}
	}
}
