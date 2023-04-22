using RestaurantApp.Modelo;
using RestaurantApp.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestaurantApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarcarContraseñas : ContentPage
    {
        public MarcarContraseñas()
        {
            InitializeComponent();
        }

        public string login;

        private void btn7_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += "7";
        }

        private void btn8_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += "8";
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += "9";
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            int contador;
            contador = txtContraseña.Text.Count();
            if (contador != 0)
            {
                txtContraseña.Text = txtContraseña.Text.Substring(0, txtContraseña.Text.Count() - 1);
            }
        }

        private void btn0_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += "0";
        }

        private void btnBorrar_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text = "";
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += "3";
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += "2";
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += "1";
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += "6";
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += "5";
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += "4";
        }

        private void txtContraseña_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void validarContraseña()
        {
            MUsuarios parametros = new MUsuarios();
            VMUsuarios funcion = new VMUsuarios();

            parametros.Password = txtContraseña.Text;
            parametros.Login = login;

        }
    }
}