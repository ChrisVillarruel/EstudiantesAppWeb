using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AppWebEstudiantes.Models;
using Microsoft.AspNetCore.Mvc;



namespace AppWebEstudiantes.Controllers
{
    public class CarreraController : Controller
    {
        //Cadena de Conexion
        private string Conexion = "data source=DBPracticas.mssql.somee.com;initial catalog=DBPracticas;user id=ristianGil_SQLLogin_1;pwd=krsxl2hcg3;";

        // GET: /<controller>/
        public IActionResult IndexCarrera()
        {
            //Consultamos nuestras Carreras y las mostramos a nuestro index

            string Query = "select [GUIDCarrera], [claveC], [nombreCarrera] from [Carreras] order by nombreCarrera";
            SqlConnection con = new SqlConnection(Conexion);
            SqlCommand sql_select = new SqlCommand(Query, con);
            List<Carrera> listaCarrera = new List<Carrera>();
            try
            {
                con.Open();
                SqlDataReader rd = sql_select.ExecuteReader();
                while (rd.Read())
                {
                    listaCarrera.Add(new Carrera
                    {
                        GUIDCarrera = (Guid)rd["GUIDCarrera"],
                        claveCarrera = (string)rd["claveC"],
                        nombreCarrera = (string)rd["nombreCarrera"]
                    });
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return View(listaCarrera);
        }

        [HttpPost]
        public IActionResult InsertarCarrera(string nombreCarrera, string clave)
        {
            Carrera c = new Carrera();
            c.nombreCarrera = nombreCarrera;
            c.claveCarrera = clave;
            int row = 0;
            string Query = "INSERT INTO Carreras ( GUIDCarrera ,claveC, nombreCarrera ) VALUES ( NEWID() ,@clave ,@nombre )";
            SqlConnection con = new SqlConnection(Conexion);
            SqlCommand sql_Insert = new SqlCommand(Query, con);
            try
            {
                con.Open();
                sql_Insert.Parameters.AddWithValue("@clave", clave);
                sql_Insert.Parameters.AddWithValue("@nombre", nombreCarrera);
                row = sql_Insert.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("IndexCarrera", "Carrera");
        }

        public int EliminarCarrera(string clave)
        {
            string query = "DELETE FROM [Carreras] WHERE [claveC] = @clave";
            SqlConnection con = new SqlConnection(Conexion);
            SqlCommand sql_delete = new SqlCommand(query, con);
            int row = 0;
            try
            {
                con.Open();
                sql_delete.Parameters.AddWithValue("@clave", clave);
                row = sql_delete.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }

            return row;
        }
        public IActionResult IndexActualizarCarrera(Guid guid)
        {
            List<Carrera> lista = new List<Carrera>();
            string queryConsulta = "select [claveC], [nombreCarrera], [GUIDCarrera] from [Carreras] where [GUIDCarrera] = @guid";
            SqlConnection con = new SqlConnection(Conexion);
            SqlCommand sqlConsulta = new SqlCommand(queryConsulta, con);
            try
            {
                con.Open();
                sqlConsulta.Parameters.AddWithValue("@guid", guid);
                SqlDataReader rd = sqlConsulta.ExecuteReader();
                while (rd.Read())
                {
                    lista.Add(new Carrera
                    {
                        nombreCarrera = (string)rd["nombreCarrera"],
                        claveCarrera = (string)rd["claveC"]
                    });
                }
                con.Close();
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }

            return View(lista);
        }
        public IActionResult Actualizar(string nombreActualizado, string claveCarrera)
        {

            int row = 0;
            string queryUpdate = "UPDATE [Carreras] SET [nombreCarrera] = @nombreActualizado where [claveC] = @claveCarrera";
            SqlConnection con = new SqlConnection(Conexion);
            SqlCommand sqlUpdate = new SqlCommand(queryUpdate, con);
            try
            {
                con.Open();
                sqlUpdate.Parameters.AddWithValue("@nombreActualizado", nombreActualizado);
                sqlUpdate.Parameters.AddWithValue("@claveCarrera", claveCarrera);
                row = sqlUpdate.ExecuteNonQuery();
                return RedirectToAction("IndexCarrera");
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
