using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.clases
{
    internal class CCuenta
    {
        public void mostrarCuenta(DataGridView tablaCuentas)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "SELECT * FROM cuenta";
                tablaCuentas.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaCuentas.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No muestra datos en la base de datos" + ex.ToString());
            }
        }
        public void guardarCuentas(TextBox carnet , TextBox tipo, TextBox monto)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "INSERT INTO cuenta(carnet,tipo,monto,estado)" + "values ('" + carnet.Text + "','" + tipo.Text + "','" + monto.Text + "','" + 1 + "');";


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
        public void seleccionarCuenta(DataGridView tablaCuentas, TextBox Carnet, TextBox id_cuenta, TextBox tipo, TextBox monto)
        {
            try
            {
                Carnet.Text = tablaCuentas.CurrentRow.Cells[1].Value.ToString();
                id_cuenta.Text = tablaCuentas.CurrentRow.Cells[0].Value.ToString();
                monto.Text = tablaCuentas.CurrentRow.Cells[2].Value.ToString();
                tipo.Text = tablaCuentas.CurrentRow.Cells[3].Value.ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo seleccionar datos" + ex.ToString());
            }
        }
        public void modificarCuentas(TextBox id_cuenta,  TextBox tipo_cuenta, TextBox monto)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                Console.WriteLine(id_cuenta.Text + " " + monto.Text);
                String query = "UPDATE cuenta set tipo='"
                    + tipo_cuenta.Text + "', monto= '"+
                    monto.Text +"' where id_cuenta='" + id_cuenta.Text + "';";


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
                MessageBox.Show("No se modifico los datos" + ex.ToString());
            }
        }
        public void eliminarCuentas(TextBox idcuen)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "delete from  cuenta where id_cuenta= '" + idcuen.Text + "';";

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
