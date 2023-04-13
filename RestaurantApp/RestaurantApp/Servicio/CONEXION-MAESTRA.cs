using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace RestaurantApp.Servicio
{
    public class CONEXION_MAESTRA
    {
        public static string conexion = "Data Source=192.168.0.2;Initial Catalog=BDRestauCSHARP;Integrated Security=False;User Id = SA; Password=1234";
        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void Cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
