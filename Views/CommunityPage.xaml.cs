using PlanTechShenApp.Community;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlanTechShenApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommunityPage : ContentPage
    {
        public CommunityPage()
        {
            InitializeComponent();
        }
        private void OnToolbarItemClicked(object sender, EventArgs e)
        {

        }
        private async void ClientSupportClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClientSupportPage());
        }
        private async void SettingsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }

        private async void ImageClicked(object sender, EventArgs e)
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                await Browser.OpenAsync("https://www.gardening-forums.com/forums/general-gardening-talk.5/");

                //   System.Diagnostics.Process.Start("https://www.gardening-forums.com/forums/general-gardening-talk.5/ ");
            }
        }

    }
}