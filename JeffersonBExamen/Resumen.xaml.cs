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
    public partial class Resumen : ContentPage
    {
        public Resumen(string user, string nombre, decimal total)
        {
            InitializeComponent();
            lblUser.Text = user;
            lblNombre.Text = nombre;
            lblTotalPaga.Text = total.ToString("F2");
        }
    }
}