using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RestaurantApp.VistaModelo;
using System.Data;
using RestaurantApp.Modelo;

namespace RestaurantApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mesas : ContentPage
    {
        public Mesas()
        {
            InitializeComponent();
            dibujarSalones();
            
        }

        int idsalon;

        public void dibujarSalones()
        {
            DataTable dt = new DataTable();
            VMSalones funcion = new VMSalones();
            funcion.dibujarSalones(ref dt);

            foreach (DataRow rdr in dt.Rows)
            {
                Button b = new Button();
                b.Text = rdr["Salon"].ToString();
                b.CommandParameter = rdr["Id_Salon"].ToString();
                b.HeightRequest = 50;
                b.WidthRequest = 150;
                b.BackgroundColor = Color.FromRgb(37, 37, 37);
                b.TextColor = Color.White;
                
                PanelSalones.Children.Add(b);
                b.Clicked += B_Clicked;

            }
        }

        private void B_Clicked(object sender, EventArgs e)
        {
            idsalon = Convert.ToInt32(((Button)sender).CommandParameter);
            DibujarMesasPorSalon();
        }

        private void DibujarMesasPorSalon()
        {
            PanelMesas.Children.Clear();
            DataTable dt = new DataTable();
            MSalones parametros = new MSalones();
            MMesas parametrosMesas = new MMesas();

            VMMesas funcion = new VMMesas();

            parametros.Id_salon = idsalon;
            funcion.DibujarMesasPorSalon(parametros, ref dt);

            foreach (DataRow rdr in dt.Rows)
            {
                string estadoMesa;
                Button b = new Button();
                b.Text = rdr["Mesa"].ToString();
                b.HeightRequest = 110;
                b.WidthRequest = 100;
                estadoMesa = rdr["Estado_Disponibilidad"].ToString();

                if (estadoMesa == "LIBRE")
                {
                    b.BackgroundColor = Color.FromRgb(2, 197, 75);

                }
                else
                {
                    b.BackgroundColor = Color.FromRgb(221,80,67);
                }

                PanelMesas.Children.Add(b);

            }

        }
    }
}