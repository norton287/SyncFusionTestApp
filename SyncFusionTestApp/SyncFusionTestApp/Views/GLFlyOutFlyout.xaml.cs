using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SyncFusionTestApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GLFlyOutFlyout : ContentPage
	{
		public ListView ListView;

		public GLFlyOutFlyout()
		{
			InitializeComponent();

			BindingContext = new GLFlyOutFlyoutViewModel();
			ListView = MenuItemsListView;
		}

		class GLFlyOutFlyoutViewModel : INotifyPropertyChanged
		{
			public ObservableCollection<GLFlyOutFlyoutMenuItem> MenuItems { get; set; }

			public GLFlyOutFlyoutViewModel()
			{
				 if (Device.RuntimePlatform == Device.iOS)
				 {
					 MenuItems = new ObservableCollection<GLFlyOutFlyoutMenuItem>(new[]
					 {
						 new GLFlyOutFlyoutMenuItem
						 {
							 Id = 0,
							 Title = "Home",
							 IconSource = Application.Current.Resources["Home"] as FontImageSource,
							 TargetType = typeof(MainPage)
						 },
						 new GLFlyOutFlyoutMenuItem
						 {
							 Id = 1,
							 Title = "Info",
							 IconSource = Application.Current.Resources["Info"] as FontImageSource,
							 TargetType = typeof(AppInfoView)
						 }
					 });
				 }
				 else
				 {
					 MenuItems = new ObservableCollection<GLFlyOutFlyoutMenuItem>(new[]
					 {
						 new GLFlyOutFlyoutMenuItem
						 {
							 Id = 0,
							 Title = "Home",
							 IconSource = Application.Current.Resources["Home"] as FontImageSource,
							 TargetType = typeof(MainPage)
						 },

						 new GLFlyOutFlyoutMenuItem
						 {
							 Id = 1,
							 Title = "Info",
							 IconSource = Application.Current.Resources["Info"] as FontImageSource,
							 TargetType = typeof(AppInfoView)
						 }
					 });
				 }
			}

			#region INotifyPropertyChanged Implementation
			public event PropertyChangedEventHandler PropertyChanged;
			void OnPropertyChanged([CallerMemberName] string propertyName = "")
			{
				if (PropertyChanged == null)
					return;

				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
			#endregion
		}
	}
}