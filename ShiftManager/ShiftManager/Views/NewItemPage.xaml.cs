using System;

using ShiftManager.Models;

using Xamarin.Forms;

namespace ShiftManager.Views
{
	public partial class NewItemPage : ContentPage
	{
		public Item Item { get; set; }

		public NewItemPage()
		{
			InitializeComponent();

			Item = new Item
			{
				Text = "Work name",
				Description = "A simple description"
			};

			BindingContext = this;
		}

		async void Save_Clicked(object sender, EventArgs e)
		{
			MessagingCenter.Send(this, "AddWork", Item);
			await Navigation.PopToRootAsync();
		}
	}
}