using System;
using Xamarin.Forms;

namespace SyncFusionTestApp.Views
{
	public class GLFlyOutFlyoutMenuItem
	{
		public GLFlyOutFlyoutMenuItem()
		{
			TargetType = typeof(GLFlyOutFlyoutMenuItem);
		}
		public int Id { get; set; }
		public string Title { get; set; }

		public FontImageSource IconSource { get; set; }

		public Type TargetType { get; set; }
	}
}