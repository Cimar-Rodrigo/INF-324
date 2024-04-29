using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Pregunta
{
    /// <summary>
    /// Descripción breve de ServicioWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWeb : System.Web.Services.WebService
    {


        [WebMethod]
        public int ModificarPersona(int carnet, string nombre, string apellido, string departamento, string correo, string tipo)
        {
            try
            {
                string servidor = "localhost";
                string bd = "bdejer4";
                string usuario = "root";
                string password = "";
                MySqlConnection con = new MySqlConnection();
                string cadenaConexion = "server=" + servidor + ";" + "user=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                string query = "UPDATE persona SET nombre = '" + nombre + "', apellido = '" + apellido + "', correo = '" + correo + "', tipo = '" + tipo + "', departamento = '" + departamento + "' WHERE carnet = '" + carnet+"';";
                con.ConnectionString = cadenaConexion;
                con.Open();
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Se ha modificado la persona con carnet: " + carnet);
                return 2;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        [WebMethod]
        public int AgregarPersona(int carnet, string nombre, string apellido, string correo, string tipo, string departamento)
        {
            try
            {
                string servidor = "localhost";
                string bd = "bdejer4";
                string usuario = "root";
                string password = "";
                MySqlConnection con = new MySqlConnection();
                string cadenaConexion = "server=" + servidor + ";" + "user=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                string query = "INSERT INTO persona (carnet, nombre, apellido, departamento, correo, tipo) VALUES (@carnet, @nombre, @apellido, @departamento, @correo, @tipo)";

                con.ConnectionString = cadenaConexion;
                con.Open();
                MySqlCommand comando = new MySqlCommand(query, con);

                comando.Parameters.AddWithValue("@carnet", carnet);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@departamento", departamento);

                comando.ExecuteNonQuery();

                con.Close();
                return 1; 
            }
            catch (Exception ex)
            {
                Console.WriteLine("AAA");
                Console.WriteLine(ex.Message);
                return 0; 
            }
        }

        [WebMethod]
        public int EliminarPersona(int carnet)
        {
            try
            {
                string servidor = "localhost";
                string bd = "bdejer4";
                string usuario = "root";
                string password = "";
                MySqlConnection con = new MySqlConnection();
                
                string cadenaConexion = "server=" + servidor + ";" + "user=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                string query = "DELETE FROM persona WHERE carnet = '" + carnet+ "'";
                con.ConnectionString = cadenaConexion;
                con.Open();
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Se ha eliminado la persona con carnet: " + carnet);
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }


    }
}
