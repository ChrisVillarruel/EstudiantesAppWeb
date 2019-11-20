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

            //Creamos un query, el cual se ejecutara de manera de lectura, para mostrame de regreso sus registros 
            string query = "SELECT [IDEstudiante], [nombre], [aPaterno], [aMaterno], [cuatrimestre], [promedio], [nombreCarrera] FROM Estudiantes E, Carreras C WHERE E.GUIDCarrera = C.GUIDCarrera";

            //Abrimos una nueva Conexion
            SqlConnection con = new SqlConnection(Conexion);
            //Ejecutamos el query con su respectiva conexion
            SqlCommand sql_select = new SqlCommand(query, con);

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
                        cuatrimestre = (int)dr["cuatrimestre"],
                        promedio = (float)dr["promedio"],
                        nombreCarrera = (string)dr["nombreCarrera"]
                    });

                }

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
        public IActionResult InsertarEstudiante(string nombre, string aPaterno, string aMaterno, float promedio, int cuatrimestre, string correo, int tel, Int64 cel, Guid GUIDCarrera)
        {

            Estudiantes e = new Estudiantes();
            e.Nombre = nombre;
            e.apellidoPaterno = aPaterno;
            e.apellidoMaterno = aMaterno;
            e.promedio = promedio;
            e.cuatrimestre = cuatrimestre;
            e.correo = correo;
            e.telefono = tel;
            e.celular = cel;
            e.GUIDCarrera = GUIDCarrera;

            int row = 0;
            //Creamos un query, el cual se ejecutara de manera de lectura, para mostrame de regreso sus registros 
            string query = "INSERT INTO [Estudiantes]  VALUES (NEWID(),@nombre,@aPaterno,@aMaterno,@promedio,@cuatrimestre,@correo,@tel,@cel,@GUIDCarrera)";
            //Abrimos una nueva Conexion
            SqlConnection con = new SqlConnection(Conexion);
            //Ejecutamos el query con su respectiva conexion
            SqlCommand sql_insert = new SqlCommand(query, con);

            try
            {
                con.Open();
                sql_insert.Parameters.AddWithValue("@nombre", nombre);
                sql_insert.Parameters.AddWithValue("@aPaterno", aPaterno);
                sql_insert.Parameters.AddWithValue("@aMaterno", aMaterno);
                sql_insert.Parameters.AddWithValue("@promedio", promedio);
                sql_insert.Parameters.AddWithValue("@cuatrimestre", cuatrimestre);
                sql_insert.Parameters.AddWithValue("@correo", correo);
                sql_insert.Parameters.AddWithValue("@tel", tel);
                sql_insert.Parameters.AddWithValue("@cel", cel);
                sql_insert.Parameters.AddWithValue("@GUIDCarrera", GUIDCarrera);
                row = sql_insert.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException sqle)
            {
                throw new Exception(sqle.Message);
            }

            return RedirectToAction("IndexEstudiantes", "Estudiantes");
        }

        public IActionResult jComCarrera()
        {
            //Creamos la lista donde se almacenara cada iteracion de la consulta de la tabla Carrera
            List<Estudiantes> listaCarrera = new List<Estudiantes>();

            //Creamos un query, el cual se ejecutara de manera de lectura, para mostrame de regreso sus registros de la tabla
            string query = "SELECT [GUIDCarrera],[nombreCarrera] FROM Carreras";

            //Abrimos una nueva Conexion
            SqlConnection con = new SqlConnection(Conexion);
            //Ejecutamos el query con su respectiva conexion
            SqlCommand sql_select = new SqlCommand(query, con);

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
                    listaCarrera.Add(new Estudiantes
                    {
                        GUIDCarrera = (Guid)dr["GUIDCarrera"],
                        nombreCarrera = (string)dr["nombreCarrera"]
                    });
                    //se acaba la iteracion
                }

                //cerramos la conexion
                con.Close();
            }
            catch (SqlException sqle)
            {
                //imprimos en mensaje en el IDE VisaulS, si hay un tipo exception en la conexion a la BD
                throw new Exception(sqle.Message);
            }

            return View(listaCarrera);
        }

        public int EliminarEstudiante(string claveEstudiante)
        {
            //creamos un query, el cual me permitira eliminar un registro de la tabla estudiantes
            string query = "DELETE FROM [Estudiantes] WHERE [IDEstudiante] = @claveEstudiante";

            //creamos una varriable llamada row, la cual me regresara un numero de estudiantes eliminado
            int row = 0;

            //creamos una nueva conexion
            SqlConnection con = new SqlConnection(Conexion);

            //Ejecutamos el query con su respectiva conexion
            SqlCommand sql_delete = new SqlCommand(query, con);

            try
            {
                //abrimos la conexion dentro de la sentencia try y catch, por si llega a ver un error de tipo exception
                con.Open();

                //leemos el parametro @claveEstudiante, el cual contiene el id del Estudiante
                sql_delete.Parameters.AddWithValue("@claveEstudiante", claveEstudiante);

                //Ejecutamos la sentecia ExecuteNonQuery, porque no me va aregresar registros, si no solo un numero
                row = sql_delete.ExecuteNonQuery();

                //cerramos la Conexion
                con.Close();
            }
            catch (SqlException sqle)
            {
                //imprimos en mensaje en el IDE VisaulS, si hay un tipo exception en la conexion a la BD
                throw new Exception(sqle.Message);
            }

            return row;
        }

        public IActionResult IndexActualizarEstudiante(Guid claveEstudiante)
        {
            //Creamos la lista donde se almacenara cada iteracion de la consulta
            List<Estudiantes> listaEstudiantes = new List<Estudiantes>();

            //Creamos un query, el cual se ejecutara de manera de lectura, para mostrame de regreso sus registros 
            string query =
                "SELECT E.IDEstudiante, E.nombre, E.aPaterno, E.aMaterno, E.promedio, E.cuatrimestre, E.correo, E.telFijo, E.celular, E.GUIDCarrera, C.nombreCarrera" +
                " FROM Estudiantes E, Carreras C WHERE E.GUIDCarrera = C.GUIDCarrera AND E.IDEstudiante = @claveEstudiante";

            //Abrimos una nueva Conexion
            SqlConnection con = new SqlConnection(Conexion);
            //Ejecutamos el query con su respectiva conexion
            SqlCommand sql_select = new SqlCommand(query, con);

            try
            {
                //Abrimos la Conexion
                con.Open();

                //leemos el parametro
                sql_select.Parameters.AddWithValue("@claveEstudiante", claveEstudiante);

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
                        cuatrimestre = (int)dr["cuatrimestre"],
                        correo = (string)dr["correo"],
                        telefono = (int)dr["telFijo"],
                        celular = (Int64)dr["celular"],
                        GUIDCarrera = (Guid)dr["GUIDCarrera"],
                        nombreCarrera = (string)dr["nombreCarrera"]
                    });

                }

                con.Close();
            }
            catch (SqlException sqle)
            {
                //imprimos en mensaje el IDE VS, si hay un tipo exception en la conexion
                throw new Exception(sqle.Message);
            }

            return View(listaEstudiantes);
        }

        public IActionResult Actualizar(string nombre, string aPaterno, string aMaterno, float promedio, int cuatrimestre, string correo, int tel, Int64 cel, Guid GUIDCarrera, Guid idEstudiante)
        {

            Estudiantes e = new Estudiantes();
            e.Nombre = nombre;
            e.apellidoPaterno = aPaterno;
            e.apellidoMaterno = aMaterno;
            e.promedio = promedio;
            e.cuatrimestre = cuatrimestre;
            e.correo = correo;
            e.telefono = tel;
            e.celular = cel;
            e.GUIDCarrera = GUIDCarrera;
            e.IDEstudiante = idEstudiante;

            int row = 0;
            //Creamos un query, el cual se ejecutara de manera de lectura, para mostrame de regreso sus registros 
            string query = "UPDATE Estudiantes SET Nombre = @nombre, aPaterno = @aPaterno, aMaterno = @aMaterno, promedio = @promedio, " +
                "cuatrimestre = @cuatrimestre, correo = @correo, telFijo = @tel, celular = @cel, GUIDCarrera = @GUIDCarrera WHERE [IDEstudiante] = @idEstudiante";
           
            //Abrimos una nueva Conexion
            SqlConnection con = new SqlConnection(Conexion);
            //Ejecutamos el query con su respectiva conexion
            SqlCommand sql_update = new SqlCommand(query, con);

            try
            {
                con.Open();
                sql_update.Parameters.AddWithValue("@nombre", nombre);
                sql_update.Parameters.AddWithValue("@aPaterno", aPaterno);
                sql_update.Parameters.AddWithValue("@aMaterno", aMaterno);
                sql_update.Parameters.AddWithValue("@promedio", promedio);
                sql_update.Parameters.AddWithValue("@cuatrimestre", cuatrimestre);
                sql_update.Parameters.AddWithValue("@correo", correo);
                sql_update.Parameters.AddWithValue("@tel", tel);
                sql_update.Parameters.AddWithValue("@cel", cel);
                sql_update.Parameters.AddWithValue("@GUIDCarrera", GUIDCarrera);
                sql_update.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                row = sql_update.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException sqle)
            {
                throw new Exception(sqle.Message);
            }

            return RedirectToAction("IndexEstudiantes", "Estudiantes");


        }
    }
}
