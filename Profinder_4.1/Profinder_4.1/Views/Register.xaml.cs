using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Profinder_4._1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Register : ContentPage
{
    public Register()
    {
        InitializeComponent();
    }

        private void GoBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}