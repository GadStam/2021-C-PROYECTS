using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Dapper;
namespace TPVOTO.Models
{
    public static class BD
    {
        private static string _connectionString = @"Server=A-CAM-04; DataBase=BDPadron; Trusted_Connection=True;";

        public static Persona ConsultaPadron(int DNI){
            Persona MiPersona=null;
            string sql="SELECT * FROM Personas WHERE DNI=@pDNI";
            using(SqlConnection BD=new SqlConnection(_connectionString)){
                MiPersona=BD.QueryFirstOrDefault<Persona>(sql,new{pDNI=DNI});
            }
            return MiPersona;
        }

        public static Establecimiento ConsultaEstablecimiento(int IdEstablecimiento){
            Establecimiento MiEstablecimiento=null;
            string sql="SELECT * FROM Establecimiento WHERE IdEstablecimiento=@pIdEstablecimiento";
            using(SqlConnection BD=new SqlConnection(_connectionString)){
                MiEstablecimiento=BD.QueryFirstOrDefault<Establecimiento>(sql,new{pIdEstablecimiento=IdEstablecimiento});
            }
            return MiEstablecimiento;
        }
        public static bool Votar(int DNI, int NumeroTramite){
            bool MiVoto=false;
            int personasVotadas=0;
            string sql="UPDATE Personas SET Voto = 1, Fecha_Voto=@pFecha WHERE DNI=@pDNI and NumeroTramite=@pNumeroTramite";
            using(SqlConnection BD=new SqlConnection(_connectionString)){
                personasVotadas=BD.Execute(sql,new{pDNI=DNI,pNumeroTramite=NumeroTramite,pFecha=DateTime.Today});
            }
            if(personasVotadas==1){
                MiVoto=true;
            }
            return MiVoto;
        }
    }
}