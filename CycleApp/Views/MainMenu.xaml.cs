using CycleApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XLabs.Forms.Controls;
using System.Collections.Specialized;
using System.ComponentModel;

namespace CycleApp.Views
{
    public partial class MainMenu : ExtendedTabbedPage
    {
        public MainMenu()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.PropertyChanged += SetConfigurationSize;
        }

        private void SetConfigurationSize(object sender, PropertyChangedEventArgs e)
        {
            
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
