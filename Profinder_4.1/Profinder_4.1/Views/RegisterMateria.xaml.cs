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
public partial class RegisterMateria : ContentPage
{
    public RegisterMateria()
    {
        InitializeComponent();
    }

        private void GoBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Save(object sender, EventArgs e)
        {
            DisplayAlert("Matéria Salva", "A matéria foi cadastrada!", "OK");
            Navigation.PopAsync();
        }
    }
}