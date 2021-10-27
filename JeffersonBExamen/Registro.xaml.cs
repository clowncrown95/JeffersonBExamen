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
    public partial class Registro : ContentPage
    {
        string _user = string.Empty;
        public Registro(string user)
        {
            InitializeComponent();
            _user = user;
            txtUser.Text = "Usuario conectado:"+ _user;
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            decimal costoTotal = 1800;
            decimal interes = (costoTotal * 5) / 100;
            decimal montoInicial = 0;
            montoInicial = Convert.ToDecimal(txtMontoInicial.Text);
            decimal montoDiferencia = costoTotal - montoInicial;
            decimal valorCuota = montoDiferencia / 3;
            decimal valorCuotaFinal = valorCuota + interes;
            decimal totalPaga = montoDiferencia + (valorCuotaFinal * 3);
            await Navigation.PushModalAsync(new Resumen(_user, txtNombre.Text, totalPaga));
        }
    }
}