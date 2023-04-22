using RestaurantApp.Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Xamarin.Forms;
using System.Data.SqlClient;

namespace RestaurantApp.VistaModelo
{
    public class VMSalones
    {
        public void dibujarSalones(ref DataTable dt)
        {
            try
            {
                CONEXION_MAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Salon Where Estado = 'ACTIVO'",CONEXION_MAESTRA.conectar);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                Application.Current.MainPage.DisplayAlert("Error", ex.StackTrace, "Aceptar");
            }
            finally
            {
                CONEXION_MAESTRA.Cerrar();
            }
        }
    }
}
