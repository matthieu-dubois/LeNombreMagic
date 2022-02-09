using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace nombremagique.Views
{
    public partial class GamePage : ContentPage
    {
        const int NB_MAGIQUE_MIN = 1;
        const int NB_MAGIQUE_MAX = 4;
        int nombreMagique = 0;

        public GamePage()
        {
            InitializeComponent();
            nombreMagique = new Random().Next(NB_MAGIQUE_MIN, NB_MAGIQUE_MAX);
            minMaxLabel.Text = "Entre " + NB_MAGIQUE_MIN + " et " + NB_MAGIQUE_MAX;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void ButtonClick(object sender, System.EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(numberEntry.Text)) {
                DisplayAlert("Oops", "Vous devez rentrer un nombre", "OK");
                return;
            }

            int nombreUtilisateur = 0;

            try
            {
                nombreUtilisateur = Int32.Parse(numberEntry.Text);
            }
            catch (Exception) {
                DisplayAlert("Oops", "Vous devez rentrer uniquement des chiffres", "OK");
                return;
            }

            if ((nombreUtilisateur < NB_MAGIQUE_MIN)||(nombreUtilisateur > NB_MAGIQUE_MAX)) {
                DisplayAlert("Oops", "Vous devez rentrer un nombre entre " + NB_MAGIQUE_MIN + " et " + NB_MAGIQUE_MAX, "OK");
                return;
            }

            if (nombreMagique > nombreUtilisateur) {
                DisplayAlert("Oops", "Le nombre magique est supérieur à " + nombreUtilisateur, "OK");
                return;
            }
            if (nombreMagique < nombreUtilisateur)
            {
                DisplayAlert("Oops", "Le nombre magique est inférieur à " + nombreUtilisateur, "OK");
                return;
            }
            if (nombreMagique == nombreUtilisateur)
            {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                WinAction();
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                return;
            }
        }

        private async Task WinAction() {
            //await DisplayAlert("Gagné", "Vous avez trouvé le nombre magique", "OK");
            //await this.Navigation.PopAsync();
            await Navigation.PushAsync(new WinPage(nombreMagique));
        }
    }
}
