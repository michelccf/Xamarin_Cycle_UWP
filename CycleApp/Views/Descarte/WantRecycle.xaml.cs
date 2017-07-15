using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleApp.ViewModels;
using Xamarin.Forms;
using XLabs.Forms.Mvvm;
namespace CycleApp.Views.Descarte
{
    public partial class WantRecycle : ContentPage
    {
        public WantRecycle()
        {
            InitializeComponent();
            //Define a respectiva viewmodel no Contexto da tela.
            this.BindingContext = new WantRecycleViewModel();

            //Define qual método o comportamento de toque na tela deve executar, Cada Imagem tem seu proprio método caso seja tocada.
            TapGestureRecognizer imageTap1 = new TapGestureRecognizer();
            imageTap1.Tapped += (object sender, EventArgs e) =>
            {
                App.Current.MainPage = new NavigationPage(new RecycleWhatCellphones());
            };
            Celular.GestureRecognizers.Add(imageTap1);

            TapGestureRecognizer imageTap2 = new TapGestureRecognizer();
            imageTap2.Tapped += async (object sender, EventArgs e) =>
            {
                await this.Navigation.PushAsync(new RecycleWhatCellphones());
            };
            Tablet.GestureRecognizers.Add(imageTap2);

        }
        
    }
}
