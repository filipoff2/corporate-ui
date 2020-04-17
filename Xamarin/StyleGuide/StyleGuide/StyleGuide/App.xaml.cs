using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using StyleGuide.Services;
using StyleGuide.Views;

[assembly: ExportFont("Tech_Headlines.ttf", Alias = "Headlines")]
[assembly: ExportFont("Byom_Icons_Trial.ttf", Alias = "Icons")]
namespace StyleGuide
{

    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
