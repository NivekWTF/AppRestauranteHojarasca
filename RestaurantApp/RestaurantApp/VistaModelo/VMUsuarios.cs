using RestaurantApp.Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Xamarin.Forms;

namespace RestaurantApp.VistaModelo
{
    public class VMUsuarios
    {
        public void DibujarUsuarios(ref DataTable dt)
        {
            try
            {
                CONEXION_MAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_UsuariosActivos", CONEXION_MAESTRA.conectar);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Error", ex.StackTrace, "Ok");
            }
            finally
            {
                CONEXION_MAESTRA.Cerrar();
            }
        }
    }
}
