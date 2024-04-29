namespace Ejer4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPersona = new DataGridView();
            dgvCuenta = new DataGridView();
            btnObtener = new Button();
            Carnet = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Departamento = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Carnet_cuenta = new DataGridViewTextBoxColumn();
            Tipo_cuenta = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPersona).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).BeginInit();
            SuspendLayout();
            // 
            // dgvPersona
            // 
            dgvPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersona.Columns.AddRange(new DataGridViewColumn[] { Carnet, nombre, Apellido, Departamento, Correo, Tipo });
            dgvPersona.Location = new Point(57, 45);
            dgvPersona.Name = "dgvPersona";
            dgvPersona.Size = new Size(643, 150);
            dgvPersona.TabIndex = 1;
            dgvPersona.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dgvCuenta
            // 
            dgvCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuenta.Columns.AddRange(new DataGridViewColumn[] { Carnet_cuenta, Tipo_cuenta, Monto });
            dgvCuenta.Location = new Point(57, 233);
            dgvCuenta.Name = "dgvCuenta";
            dgvCuenta.Size = new Size(643, 150);
            dgvCuenta.TabIndex = 1;
            // 
            // btnObtener
            // 
            btnObtener.Location = new Point(57, 401);
            btnObtener.Name = "btnObtener";
            btnObtener.Size = new Size(115, 23);
            btnObtener.TabIndex = 2;
            btnObtener.Text = "Obtener datos";
            btnObtener.UseVisualStyleBackColor = true;
            btnObtener.Click += btnObtener_Click;
            // 
            // Carnet
            // 
            Carnet.HeaderText = "Carnet";
            Carnet.Name = "Carnet";
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Departamento
            // 
            Departamento.HeaderText = "Departamento";
            Departamento.Name = "Departamento";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            // 
            // Carnet_cuenta
            // 
            Carnet_cuenta.HeaderText = "Carnet";
            Carnet_cuenta.Name = "Carnet_cuenta";
            // 
            // Tipo_cuenta
            // 
            Tipo_cuenta.HeaderText = "Tipo";
            Tipo_cuenta.Name = "Tipo_cuenta";
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnObtener);
            Controls.Add(dgvCuenta);
            Controls.Add(dgvPersona);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPersona).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPersona;
        private DataGridView dgvCuenta;
        private Button btnObtener;
        private DataGridViewTextBoxColumn Carnet;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Carnet_cuenta;
        private DataGridViewTextBoxColumn Tipo_cuenta;
        private DataGridViewTextBoxColumn Monto;
    }
}
