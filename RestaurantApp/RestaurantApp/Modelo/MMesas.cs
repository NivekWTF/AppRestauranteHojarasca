using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Modelo
{
    public class MMesas
    {
        private int _Id_mesa;
        private string _Mesa;
        private int _Id_salon;
        private string _Estado_vida;
        private string _Estado_Disponibilidad;
        public int Id_mesa
        {
            get { return _Id_mesa; }
            set { _Id_mesa = value; }
        }
        public string Mesa
        {
            get { return _Mesa; }
            set { _Mesa = value; }
        }
        public int Id_salon
        {
            get { return _Id_salon; }
            set { _Id_salon = value; }
        }
        public string Estado_vida
        {
            get { return _Estado_vida; }
            set { _Estado_vida = value; }
        }
        public string Estado_Disponibilidad
        {
            get { return _Estado_Disponibilidad; }
            set { _Estado_Disponibilidad = value; }
        }
    }
}
