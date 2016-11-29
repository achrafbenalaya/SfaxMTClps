using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SfaxMTClps
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
           
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Hello", "MTC LPS", "ok");
            l1.Rotation = 0;
            l1.RotateTo(360, 2000);
            await l1.ScaleTo(5, 1000);
            await l1.ScaleTo(1, 1000);

            await i1.RotateTo(15, 1000, new Easing(t => Math.Sin(Math.PI * t) * Math.Sin(Math.PI * 20 * t)));


        }
    }
}
