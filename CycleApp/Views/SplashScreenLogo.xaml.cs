using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleApp.Common;

using Xamarin.Forms;

namespace CycleApp.Views
{
    public partial class SplashScreenLogo : ContentPage
    {
        public SplashScreenLogo()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        async Task Animation()
        {
            await stack.FadeTo(0, 0);
            await stack.FadeTo(1, 2000);
        }

        async protected override void OnAppearing()
        {
            base.OnAppearing();
            await Animation();
            await Task.Delay(TimeSpan.FromSeconds(2));

            this.AbortAnimation("ChildAnimations");
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new MainMenu()) { BarTextColor = Palette._defaultGreen, BarBackgroundColor = Palette._MenuWhite, Icon = "tabicon.png" });
        } 

    }
}
