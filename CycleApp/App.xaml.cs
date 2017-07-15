using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CycleApp.Views;
using Xamarin.Forms;
using XLabs.Forms.Mvvm;
using ImageCircle.Forms.Plugin.Abstractions;
using CycleApp.Views.Descarte;
using CycleApp.ViewModels;

namespace CycleApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            SetPages();
            SplashScreenLogo splashScreen = new SplashScreenLogo();
            MainPage = splashScreen;
        }

        private void SetPages()
        {

            ///<summary>
            ///carregar em cache as telas a serem iniciadas
            ///</summary>

            //ViewFactory.Register<RecycleWhatCellphones, RecycleWhatCellphonesViewModel>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
