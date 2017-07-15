using CycleApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CycleApp.Views.Descarte
{
    public partial class RecycleWhatCellphones : ContentPage
    {
        public RecycleWhatCellphones()
        {
            InitializeComponent();
            this.BindingContext = new RecycleWhatCellphonesViewModel();
        }
    }
}
