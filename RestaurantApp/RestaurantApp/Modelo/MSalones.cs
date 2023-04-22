using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Modelo
{
    public class MSalones
    {
        private int _Id_salon;
        private string _Salon;
        private string _Estado;
        public int Id_salon
        {
            get { return _Id_salon; }
            set { _Id_salon = value; }
        }
        public string Salon
        {
            get { return _Salon; }
            set { _Salon = value; }
        }
        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }
}
