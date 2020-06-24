using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module06_TP01
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Connection_Clicked()
        {
            error.Text = "";
            error.IsVisible = false;

            if (this.id.Text == null || string.IsNullOrEmpty(this.id.Text) || this.id.Text.Length < 3)
            {
                error.Text = "L'identifiant doit posséder au moins 3 carractères.";
                error.IsVisible = true;
                return;
            }
            if (this.mdp.Text == null || string.IsNullOrEmpty(this.mdp.Text) || this.mdp.Text.Length < 6)
            {
                error.Text = "Le mot de passe doit posséder au moins 6 carractères.";
                error.IsVisible = true;
                return;
            }
            this.scroll.IsVisible = true;
            this.form.IsVisible = false;

        }
    }
}
