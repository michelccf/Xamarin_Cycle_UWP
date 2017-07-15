using CycleApp.Views;
using CycleApp.Views.Descarte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XLabs;
using XLabs.Forms.Mvvm;
namespace CycleApp.ViewModels
{

    public class WantRecycleViewModel : ViewModel
    {



        public WantRecycleViewModel()
        {
            this.CellphoneTapped = new RelayCommand(async () => {
                await ImagesTapped(0);
            });

            this.TabletTapped = new RelayCommand(async () => {
                await ImagesTapped(1);
            });
        }

        public ICommand CellphoneTapped { protected set; get; }

        public ICommand TabletTapped { protected set; get; }

        public async Task ImagesTapped(int Flux)
        {

            switch (Flux)
            {
                case 0:
                    await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new RecycleWhatCellphones()) { BarTextColor = Palette._defaultGreen, BarBackgroundColor = Palette._MenuWhite, Icon = "tabicon.png" });
                    break;
                case 1:
                    await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new RecycleWhatCellphones()) { BarTextColor = Palette._defaultGreen, BarBackgroundColor = Palette._MenuWhite, Icon = "tabicon.png" });
                    break;
            }
        }

    }
}
