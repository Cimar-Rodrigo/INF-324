namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            clases.CPersona objetoPersona = new clases.CPersona();
            objetoPersona.mostrarPersonas(dgvPersona);
            clases.CCuenta objetoCuenta = new clases.CCuenta();
            objetoCuenta.mostrarCuenta(dgvCuenta);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            clases.CPersona objetoPersona = new clases.CPersona();
            objetoPersona.guardarPersonas(txtCarnet, txtNombre, txtApellido, txtDepartamento);
            objetoPersona.mostrarPersonas(dgvPersona);
        }

        private void dgvPersona_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clases.CPersona objetoPersona = new clases.CPersona();
            objetoPersona.seleccionarPersonas(dgvPersona, txtCarnet, txtNombre, txtApellido, txtDepartamento);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            clases.CPersona objetoPersona = new clases.CPersona();
            objetoPersona.modificarPersonas(txtCarnet, txtNombre, txtApellido, txtDepartamento);
            objetoPersona.mostrarPersonas(dgvPersona);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            clases.CPersona objetoPersona = new clases.CPersona();
            objetoPersona.eliminarPersonas(txtCarnet);
            objetoPersona.mostrarPersonas(dgvPersona);
        }


        private void btnguardarcuenta_Click(object sender, EventArgs e)
        {
            clases.CCuenta objetoCuenta = new clases.CCuenta();
            objetoCuenta.guardarCuentas(txtCarnett, txtTipo, txtMonto);
            objetoCuenta.mostrarCuenta(dgvCuenta);
        }



        private void btnmodificarcuenta_Click(object sender, EventArgs e)
        {
            clases.CCuenta objetoCuenta = new clases.CCuenta();
            Console.WriteLine(txtIdCuenta);
            objetoCuenta.modificarCuentas(txtIdCuenta, txtTipo, txtMonto);
            objetoCuenta.mostrarCuenta(dgvCuenta);
        }

        private void dgvCuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clases.CCuenta objetoCuenta = new clases.CCuenta();
            objetoCuenta.seleccionarCuenta(dgvCuenta, txtCarnett, txtIdCuenta, txtMonto, txtTipo);
        }

        private void btneliminarcuenta_Click(object sender, EventArgs e)
        {
            clases.CCuenta objetoCuenta = new clases.CCuenta();
            objetoCuenta.eliminarCuentas(txtIdCuenta);
            objetoCuenta.mostrarCuenta(dgvCuenta);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
