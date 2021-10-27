using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JeffersonBExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login1 : ContentPage
    {
        public Login1()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            try
            {
                string user = "estudiante2021";
                string pass = "uisrael2021";
                if (txtUser.Text.Equals(user) && txtPass.Text.Equals(pass))
                {
                    await Navigation.PushModalAsync(new Registro(txtUser.Text));
                }
                else
                {
                    await DisplayAlert("Error", "El usuario o la contraseña son incorrectos", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}