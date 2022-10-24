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
public partial class Start : ContentPage
{
    public Start()
    {
        InitializeComponent();
    }

        private void GoVisualizer(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Visualizer());
        }

        private void GoRegisterMateria(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterMateria());
        }

        private void FocusPesquisa(object sender, EventArgs e)
        {
            TxtPesquisa.Focus();
        }

        private void FocusCidade(object sender, EventArgs e)
        {
            TxtCidade.Focus();
        }
    }
}