using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Dapper;
namespace TP11.Models
{
    public static class BD
    {
        private static string _connectionString = @"Server=A-CAM-04; DataBase=BDWebCursos; Trusted_Connection=True;";

        public static Curso ConsultaCurso(int IdCurso){
            Curso MiCurso=null;
            string sql="SELECT * FROM Cursos WHERE IdCurso=@pIdCurso";
            using(SqlConnection BD=new SqlConnection(_connectionString)){
                MiCurso=BD.QueryFirstOrDefault<Curso>(sql,new{pIdCurso=IdCurso});
            }
            return MiCurso;
        }

        public static Especialidad ConsultaEspecialidad(int IdEspecialidad){
            Especialidad MiEspecialidad=null;
            string sql="SELECT * FROM Especialidades WHERE IdEspecialidad=@pIdEspecialidad";
            using(SqlConnection BD=new SqlConnection(_connectionString)){
                MiEspecialidad=BD.QueryFirstOrDefault<Especialidad>(sql,new{pIdEspecialidad=IdEspecialidad});
            }
            return MiEspecialidad;
        }

        public static List<Curso> ListarCursos(int IdEspecialidad){
             List<Curso> ListaCurso = new List<Curso>();
             string sql="";
             if(IdEspecialidad==-1){
                sql="SELECT * FROM Cursos";
             }else{
                sql="SELECT * FROM Cursos WHERE IdEspecialidad=@pIdEspecialidad";
             }
            using(SqlConnection BD=new SqlConnection(_connectionString)){
                ListaCurso=BD.Query<Curso>(sql,new{pIdEspecialidad=IdEspecialidad}).ToList();
            }
            return ListaCurso;
        }

        public static List<Especialidad> ListarEspecialidades(){
            List<Especialidad> ListaEspecialidades = new List<Especialidad>();
            string sql = "SELECT * from Especialidades";
            using(SqlConnection BD=new SqlConnection(_connectionString)){
                ListaEspecialidades=BD.Query<Especialidad>(sql).ToList();
            }
            return ListaEspecialidades;
        }
        public static void AgregarCurso(Curso MiCurso){
            string sql="INSERT INTO Cursos( Nombre, IdEspecialidad, Descripcion, Imagen, UrlCurso, MeGusta, NoMeGusta) Values(@pNombre, @pIdEspecialidad, @pDescripcion, @pImagen, @pUrlCurso, 0, 0)";
            using(SqlConnection BD=new SqlConnection(_connectionString)){
                BD.Execute(sql,new{pIdEspecialidad=MiCurso.IdEspecialidad,pNombre=MiCurso.Nombre,pDescripcion=MiCurso.Descripcion, pImagen=MiCurso.Imagen, pUrlCurso=MiCurso.UrlCurso});
            }
        }

        public static void CalificarCurso(int IdCurso, bool Gusta){
            string sql="";
            if(Gusta==true){
                sql="UPDATE Cursos SET MeGusta=MeGusta+1 WHERE IdCurso=@pIdCurso";
            }else{
                sql="UPDATE Cursos SET NoMeGusta=NoMeGusta+1 WHERE IdCurso=@pIdCurso";
            }
            using(SqlConnection BD=new SqlConnection(_connectionString)){
                BD.Execute(sql,new{pIdCurso=IdCurso});
            }
        }
    }
}
    