using Marvel.Models;

namespace Marvel.App
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(ApisKeys.SyncfusionKey);
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
