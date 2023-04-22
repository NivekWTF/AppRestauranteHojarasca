using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RestaurantApp.VistaModelo;
using System.IO;

namespace RestaurantApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            DibujarUsuarios();
        }

        public string login;

        public void DibujarUsuarios()
        {
            DataTable dt = new DataTable();
            
            VMUsuarios funcion = new VMUsuarios();
            funcion.DibujarUsuarios(ref dt);
            foreach (DataRow rdr in dt.Rows)
            {
                Label lbl = new Label();
                StackLayout sl = new StackLayout();
                ImageButton imgb = new ImageButton();

                lbl.Text = rdr["Login"].ToString();
                lbl.HeightRequest = 25;
                lbl.FontAttributes = FontAttributes.Bold;
                lbl.BackgroundColor = Color.Transparent;
                lbl.TextColor = Color.White;
                lbl.HorizontalTextAlignment = TextAlignment.Center;
                lbl.VerticalTextAlignment = TextAlignment.Center;
                

                sl.HeightRequest = 167;
                sl.WidthRequest = 155;
                sl.BackgroundColor = Color.FromRgb(37, 37, 37);

                imgb.Source = null;
                byte[] bi = (Byte[])rdr["Icono"];
                MemoryStream ms = new MemoryStream(bi);
                imgb.Source = ImageSource.FromStream(() => ms);
                imgb.HeightRequest = 140;
                imgb.WidthRequest = 140;
                imgb.CommandParameter = (rdr["Login"].ToString());

                Frame frameImg = new Frame();
                frameImg.Content = imgb;
                frameImg.Margin = 0;
                frameImg.Padding = -16;
                frameImg.HeightRequest = sl.HeightRequest;
                frameImg.WidthRequest = sl.WidthRequest;
                frameImg.CornerRadius = 70;
                frameImg.HasShadow = false;

                frameImg.VerticalOptions = LayoutOptions.Center;
                frameImg.HorizontalOptions = LayoutOptions.Center;

                

                sl.Children.Add(lbl);
                sl.Children.Add(frameImg);

                Frame frameStackLay = new Frame();
                frameStackLay.Content = sl;
                frameStackLay.Margin = 10;
                frameStackLay.Padding = 5;
                frameStackLay.HeightRequest = sl.HeightRequest;
                frameStackLay.WidthRequest = sl.WidthRequest;
                frameStackLay.HasShadow = true;
                frameStackLay.CornerRadius = 40;
                frameStackLay.VerticalOptions = LayoutOptions.Center;
                frameStackLay.HorizontalOptions = LayoutOptions.Center;
                frameStackLay.BackgroundColor = sl.BackgroundColor;
            
                PanelUsuarios.Children.Add(frameStackLay);
                imgb.Clicked += Imgb_Clicked;


            }
        }

        private void Imgb_Clicked(object sender, EventArgs e)
        {
            login = ((ImageButton)sender).CommandParameter.ToString();
            MarcarContraseñas.login = login;
            ((NavigationPage)this.Parent).PushAsync(new MarcarContraseñas());
        }
    }
}