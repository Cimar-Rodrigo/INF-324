using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServicioWebSoapClient ws = new ServiceReference1.ServicioWebSoapClient();
            ws.ModificarPersona(Convert.ToInt32( txtCarnet.Text),txtNombre.Text,txtApellido.Text, txtDepartamento.Text, txtCorreo.Text,txtTipo.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServicioWebSoapClient ag = new ServiceReference1.ServicioWebSoapClient();
            ag.AgregarPersonaAsync(Convert.ToInt32(txtCarnet2.Text),txtNombre2.Text, txtApellido2.Text, txtCorreo2.Text, txtTipo2.Text, txtDepartamento2.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServicioWebSoapClient el = new ServiceReference1.ServicioWebSoapClient();
            el.EliminarPersonaAsync(Convert.ToInt32(txtCarnet3.Text));
        }
    }
}
