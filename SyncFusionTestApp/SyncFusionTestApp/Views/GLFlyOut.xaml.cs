using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SyncFusionTestApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GLFlyOut : FlyoutPage
	{
		public GLFlyOut()
		{
			InitializeComponent();
			FlyoutPage.ListView.ItemSelected += ListView_ItemSelected;
			FlyoutLayoutBehavior = FlyoutLayoutBehavior.Popover;
		}

		private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as GLFlyOutFlyoutMenuItem;
			if (item == null)
				return;

			var page = (Page)Activator.CreateInstance(item.TargetType);
			page.Title = item.Title;

			Detail = new NavigationPage(page);
			IsPresented = false;

			FlyoutPage.ListView.SelectedItem = null;
		}
	}
}