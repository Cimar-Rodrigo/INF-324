using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.clases
{
    internal class CPersona
    {
        public void mostrarPersonas(DataGridView tablaPersonas)
        {
           try{
                CConexion objetoConexion = new CConexion();

                String query = "SELECT * FROM persona";
                tablaPersonas.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaPersonas.DataSource = dt;
                objetoConexion.cerrarConexion();
            } 
            catch (Exception ex) { 
                MessageBox.Show("No muestra datos en la base de datos" + ex.ToString());
            }
        }
        public void guardarPersonas(TextBox carnet, TextBox nombre, TextBox apellido, TextBox departamento)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "INSERT INTO persona (carnet, nombre,apellido,departamento) values ('"+carnet.Text+"','"+nombre.Text+"','"+apellido.Text+"','"+departamento.Text+"');";
                

                MySqlCommand mycomando = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mycomando.ExecuteReader();
                MessageBox.Show("Datos guardados");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No muestra datos en la base de datos" + ex.ToString());
            }
        }
        public void seleccionarPersonas(DataGridView tablaPersonas, TextBox carnet, TextBox nombre, TextBox apellido, TextBox departamento)
        {
            try
            {
                carnet.Text = tablaPersonas.CurrentRow.Cells[0].Value.ToString();
                nombre.Text = tablaPersonas.CurrentRow.Cells[1].Value.ToString();
                apellido.Text = tablaPersonas.CurrentRow.Cells[2].Value.ToString();
            
                departamento.Text = tablaPersonas.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo seleccionar datos" + ex.ToString());
            }

        }
        public void modificarPersonas(TextBox carnet,TextBox nombre, TextBox apellido, TextBox departamento)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "UPDATE persona set nombre='"
                    + nombre.Text + "',apellido ='" + apellido.Text +
                    "',departamento ='" + departamento.Text + "' where carnet='" + carnet.Text + "';";


                MySqlCommand mycomando = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mycomando.ExecuteReader();
                MessageBox.Show("Datos modificados");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se modifico loss datos" + ex.ToString());
            }
        }
        public void eliminarPersonas(TextBox carnet)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String quer = "delete from cuenta where carnet='" + carnet.Text + "';";
                String query = "delete from persona where carnet= '" + carnet.Text + "';";
                MySqlCommand cuen = new MySqlCommand(quer, objetoConexion.establecerConexion());
                cuen.ExecuteNonQuery();
                objetoConexion.cerrarConexion();
                MySqlCommand mycomando = new MySqlCommand(query, objetoConexion.establecerConexion());
                
                MySqlDataReader reader = mycomando.ExecuteReader();
                MessageBox.Show("Sel eliminaron datos");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se elimino los datos" + ex.ToString());
            }
        }

    }
}
