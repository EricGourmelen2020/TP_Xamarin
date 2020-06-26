using Module08_TP01.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Module08_TP01
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly ITwitterService twitterService = new TwitterService();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Connection_Clicked(object sender, EventArgs e)
        {
            error.Text = "";
            error.IsVisible = false;

            var current = Connectivity.NetworkAccess;

            if (current != NetworkAccess.Internet)
            {
                error.Text = "Veuillez vérifier votre connexion internet.";
                error.IsVisible = true;
                return;
            }

            if (string.IsNullOrEmpty(this.id.Text) || this.id.Text.Length < 3)
            {
                error.Text = "L'identifiant doit posséder au moins 3 carractères.";
                error.IsVisible = true;
                return;
            }
            if (string.IsNullOrEmpty(this.mdp.Text) || this.mdp.Text.Length < 6)
            {
                error.Text = "Le mot de passe doit posséder au moins 6 carractères.";
                error.IsVisible = true;
                return;
            }
            if (this.twitterService.authenticate(id.Text, mdp.Text))
            {
                this.scroll.IsVisible = true;
                this.form.IsVisible = false;
            }
            else
            {
                error.Text = "Cet utilisateur ne peux pas se connecter";
                error.IsVisible = true;
            }
        }
    }
}
