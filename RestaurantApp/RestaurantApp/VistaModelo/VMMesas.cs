using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Data;
using System.Data.SqlClient;
using RestaurantApp.Servicio;
using RestaurantApp.Modelo;

namespace RestaurantApp.VistaModelo
{
    public class VMMesas
    {
        public void DibujarMesasPorSalon(MSalones parametros ,ref DataTable dt )
        {
            try
            {
                CONEXION_MAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_Mesas_PorSalon_Ventas", CONEXION_MAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id_salon", parametros.Id_salon);
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
