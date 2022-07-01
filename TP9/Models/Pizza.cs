using System;
using System.Collections.Generic;

namespace TP9.Models
{
    public class Pizza
    {
        private int _IdPizza;
        private string _Nombre;
        private int _Precio;
        private string _Tamaño;
        private string _UrlFoto;
        private List <ingredientes> _ListaIngredientes = new List <ingredientes>();

        public int IdPizza { 
            get { return _IdPizza;}
        }
        public string Nombre { 
            get { return _Nombre;}
        }
        public int Precio {
            get { return _Precio;}
        }

        public string Tamaño {
            get { return _Tamaño;}
        }

        public string UrlFoto {
            get { return _UrlFoto;}
        }


        public Pizza(string Nombre, int Precio, string Tamaño, string UrlFoto  )
        {
            _IdPizza = Pizzeria.devolverId();
            _Nombre = Nombre;
            _Precio=Precio;
            _Tamaño=Tamaño;
            _UrlFoto=UrlFoto;
        }
        public Pizza()
        {
            
        }

        public List<ingredientes> ListarIngredientes(){
            return _ListaIngredientes;
        }

        public List <ingredientes> AgregarIngredientes(List<ingredientes> Lista){
            _ListaIngredientes=Lista;
            return _ListaIngredientes;
        }
    }
        
}