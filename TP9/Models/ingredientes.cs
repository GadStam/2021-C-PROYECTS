using System;
using System.Collections.Generic;

namespace TP9.Models
{
    public class ingredientes
    {
        private int _IdIngredientes;
        private string _Nombre;
        private string _UrlFoto;

        public int IdIngredientes { 
            get { return _IdIngredientes;}
        }
        public string Nombre { 
            get { return _Nombre;}
        }
        public string UrlFoto {
            get { return _UrlFoto;}
        }

        public ingredientes(int IdIngredientes, string Nombre, string UrlFoto )
        {
            _IdIngredientes = IdIngredientes;
            _Nombre = Nombre;
            _UrlFoto=UrlFoto;
        }
    }
}