using RestaurantApp.Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Xamarin.Forms;
using RestaurantApp.Modelo;

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

        public void validarUsuarios(MUsuarios parametros, ref int id)
        {
            try
            {
                CONEXION_MAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("validarUsuario", CONEXION_MAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@password", parametros.Password);
                cmd.Parameters.AddWithValue("@login", parametros.Login);
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                id = 0;
            }
            finally
            {
                CONEXION_MAESTRA.Cerrar();
            }
        }
    }
}
