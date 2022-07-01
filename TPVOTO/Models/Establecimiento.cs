using System;
using System.Collections.Generic;

namespace TPVOTO.Models
{
    public class Establecimiento
    {
        private int _IdEstablecimiento;
        private string _Nombre;

        private string _Direccion;
        private string _Localidad;




        public string Nombre { 
            get{ 
                return _Nombre;
            }
            set{
                _Nombre=value;
            }
        }

        public int IdEstablecimiento { 
            get{ 
                return _IdEstablecimiento;
            }
            set{
                _IdEstablecimiento=value;
            }
        }

        public string Direccion { 
            get{ 
                return _Direccion;
            }
            set{
                _Direccion=value;
            }
        } 

        public string Localidad { 
            get{ 
                return _Localidad;
            }
            set{
                _Localidad=value;
            }
        }        

        public Establecimiento()
        {
            
        }
        public Establecimiento(int IdEstablecimiento, string Nombre, string Direccion, string Localidad)
        {
            _IdEstablecimiento=IdEstablecimiento;
            _Nombre = Nombre;
            _Direccion=Direccion;
            _Localidad=Localidad;
        }
    }
}