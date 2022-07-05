using PlanTechShenApp.Views;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlanTechShenApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignIn : ContentPage
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private async void SignInClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlantsHomeTabbedPage());
        }
    }
}