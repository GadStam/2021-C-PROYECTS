using System;
using System.Collections.Generic;

namespace TPVOTO.Models
{
    public class Persona
    {
        private int _DNI;
        private string _Nombre;
        private string _Apellido;

        private int _NumeroTramite;

        private int _IdEstablecimiento;

        private bool _Voto;

        private DateTime _Fecha_Voto;

        public int DNI { 
            get{ 
                return _DNI;
            }
            set{
                _DNI=value;
            }
        }
        
        public string Nombre { 
            get{ 
                return _Nombre;
            }
            set{
                _Nombre=value;
            }
        }


        public string Apellido { 
            get{ 
                return _Apellido;
            }
            set{
                _Apellido=value;
            }
        }
        public int NumeroTramite { 
            get{ 
                return _NumeroTramite;
            }
            set{
                _NumeroTramite=value;
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

        public bool Voto { 
            get{ 
                return _Voto;
            }
            set{
                _Voto=value;
            }
        }

        public DateTime Fecha_Voto{
            get{
                return _Fecha_Voto;
            }set{
                _Fecha_Voto=value;
            }
        }

        public Persona()
        {
            
        }
        public Persona(int DNI, string Nombre, string Apellido, int NumeroTramite, int IdEstablecimiento, bool Voto, DateTime Fecha_Voto)
        {
            _DNI = DNI;
            _Nombre = Nombre;
            _Apellido=Apellido;
            _NumeroTramite=NumeroTramite;
            _IdEstablecimiento=IdEstablecimiento;
            _Voto=Voto;
            _Fecha_Voto=Fecha_Voto;
        }
    }
}