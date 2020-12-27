﻿using SyncFusionTestApp.Views;

using Xamarin.Forms;

[assembly: ExportFont("Roboto-Regular.ttf", Alias = "PickerRegular")]
[assembly: ExportFont("Roboto-Bold.ttf", Alias = "PickerBold")]
[assembly: ExportFont("Roboto-Regular.ttf", Alias = "RobotoRegular")]
[assembly: ExportFont("Roboto-Bold.ttf", Alias = "RobotoBold")]
[assembly: ExportFont("Segoe_MDL2_Assets.ttf", Alias = "FontIcon")]
[assembly: ExportFont("fa-solid-900.ttf", Alias = "fasolid")]
[assembly: ExportFont("fa-regular-400.ttf", Alias = "faregular")]

namespace SyncFusionTestApp
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(
                "MzY3OTU0QDMxMzgyZTM0MmUzMFRCYy9QZ3pDV0RXTEk0UXVDUDVRMmRDVXlleFFYdmJTM25zUnQrRkpBMnM9");

               InitializeComponent();

            MainPage = new MDPTest();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
