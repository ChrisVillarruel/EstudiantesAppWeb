using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AppWebEstudiantes.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppWebEstudiantes.Controllers
{
    public class EstudiantesController : Controller
    {
        //Cadena de Conexion
        private string Conexion = "data source=DBPracticas.mssql.somee.com;initial catalog=DBPracticas;user id=ristianGil_SQLLogin_1;pwd=krsxl2hcg3;";

        // GET: /<controller>/
        public IActionResult IndexEstudiantes()
        {
            //Creamos la lista donde se almacenara cada iteracion de la consulta
            List<Estudiantes> listaEstudiantes = new List<Estudiantes>();

            //-----------------List<Estudiantes> listaEstudiantes2 = new List<Estudiantes>();

            //Creamos un query, el cual se ejecutara de manera de lectura, para mostrame de regreso sus registros 
            string query = "SELECT [IDEstudiante], [nombre], [aPaterno], [aMaterno], [cuatrimestre], [promedio] FROM Estudiantes";

            //Creamos un query para poder extraer los regsitros de la tabla carreras
            //-----------------string query_carreras = "SELECT [nombreCarrera] FROM Carreras";
            //Abrimos una nueva Conexion
            SqlConnection con = new SqlConnection(Conexion);
            //Ejecutamos el query con su respectiva conexion
            SqlCommand sql_select = new SqlCommand(query, con);
            //Ejecutamos ael query_carreras con su conexion
            //-------------------SqlCommand sql_selectC = new SqlCommand(query_carreras, con);

            try
            {
                //Abrimos la Conexion
                con.Open();
                //leemos a sql_select 
                SqlDataReader dr = sql_select.ExecuteReader();

                //lo ietramos registro por registro
                while (dr.Read())
                {
                    //dentro de la iteracion, se ira agregando a la lista cada elemento, hasta que no haya ningun registro por iterar
                    listaEstudiantes.Add(new Estudiantes
                    {
                        IDEstudiante = (Guid)dr["IDEstudiante"],
                        Nombre = (string)dr["nombre"],
                        apellidoPaterno = (string)dr["aPaterno"],
                        apellidoMaterno = (string)dr["aMaterno"],
                        promedio = (float)dr["promedio"],
                        cuatrimestre = (int)dr["cuatrimestre"]                        
                    });
                }
                //Cerramos la conexion
                con.Close();
            }
            catch (SqlException sqle)
            {
                //imprimos en mensaje el IDE VS, si hay un tipo exception en la conexion
                throw new Exception(sqle.Message);
            }

            return View(listaEstudiantes);
        }

        [HttpPost]
        public IActionResult InsertarEstudiante(string nombre,string aPaterno, string aMaterno, float promedio, int cuatrimestre/*, string correo, int tel, int cel, Guid GUIDCarrera*/)
        {

            Estudiantes e = new Estudiantes();
            e.Nombre = nombre;
            e.apellidoPaterno = aPaterno;
            e.apellidoMaterno = aMaterno;
            e.promedio = promedio;
            e.cuatrimestre = cuatrimestre;
            //e.correo = correo;
            //e.telefono = tel;
            //e.celular = cel;
            //e.GUIDCarrera = GUIDCarrera;

            int row = 0;
            //Creamos un query, el cual se ejecutara de manera de lectura, para mostrame de regreso sus registros 
            string query = "INSERT INTO [Estudiantes] (IDEstudiante,nombre,aPaterno,aMaterno,promedio,cuatrimestre) VALUES (NEWID(),@nombre,@aPaterno,@aMaterno,@promedio,@cuatrimestre)";
            //Abrimos una nueva Conexion
            SqlConnection con = new SqlConnection(Conexion);
            //Ejecutamos el query con su respectiva conexion
            SqlCommand sql_insert = new SqlCommand(query, con);

            try
            {
                con.Open();
                sql_insert.Parameters.AddWithValue("@nombre",nombre);
                sql_insert.Parameters.AddWithValue("@aPaterno", aPaterno);
                sql_insert.Parameters.AddWithValue("@aMaterno", aMaterno);
                sql_insert.Parameters.AddWithValue("@promedio", promedio);
                sql_insert.Parameters.AddWithValue("@cuatrimestre", cuatrimestre);
                /*sql_insert.Parameters.AddWithValue("@correo", correo);
                sql_insert.Parameters.AddWithValue("@tel", tel);
                sql_insert.Parameters.AddWithValue("@cel", cel);
                sql_insert.Parameters.AddWithValue("@GUIDCarrera", GUIDCarrera);*/
                row = sql_insert.ExecuteNonQuery();
                con.Close();
            }
            catch(SqlException sqle)
            {
                throw new Exception(sqle.Message);
            }

            return RedirectToAction("IndexEstudiantes", "Estudiantes");
        }
    }
}
