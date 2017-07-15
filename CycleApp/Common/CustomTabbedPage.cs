using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CycleApp.Common
{
    public class CustomTabbedPage : TabbedPage
    {
        public static readonly BindableProperty MenuBackgroundColor = BindableProperty.Create("BgColor", typeof(Color), typeof(CustomTabbedPage), Color.White);
        public static readonly BindableProperty MenuTextColor = BindableProperty.Create("TextColor", typeof(Color), typeof(CustomTabbedPage), Color.Black);

        public CustomTabbedPage()
        {

        }

        public Color BgColor
        {
            get
            {
                return (Color)GetValue(MenuBackgroundColor);
            }
            set
            {
                SetValue(MenuBackgroundColor, value);
            }
        }

        public Color TextColor
        {
            get
            {
                return (Color)GetValue(MenuTextColor);
            }
            set
            {
                SetValue(MenuTextColor, value);
            }
        }

    }
}
