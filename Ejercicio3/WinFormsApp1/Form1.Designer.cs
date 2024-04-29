namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            txtDepartamento = new TextBox();
            label4 = new Label();
            btneliminar = new Button();
            btnmodificar = new Button();
            btnguardar = new Button();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtCarnet = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvPersona = new DataGridView();
            groupBox2 = new GroupBox();
            txtIdCuenta = new TextBox();
            label5 = new Label();
            txtTipo = new TextBox();
            label7 = new Label();
            btneliminarcuenta = new Button();
            btnmodificarcuenta = new Button();
            btnguardarcuenta = new Button();
            txtCarnett = new TextBox();
            label10 = new Label();
            dgvCuenta = new DataGridView();
            label6 = new Label();
            txtMonto = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersona).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDepartamento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btneliminar);
            groupBox1.Controls.Add(btnmodificar);
            groupBox1.Controls.Add(btnguardar);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtCarnet);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 30);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(328, 244);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Persona";
            // 
            // txtDepartamento
            // 
            txtDepartamento.HideSelection = false;
            txtDepartamento.Location = new Point(98, 107);
            txtDepartamento.Margin = new Padding(3, 2, 3, 2);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(183, 23);
            txtDepartamento.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 107);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 9;
            label4.Text = "Departamento";
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(28, 198);
            btneliminar.Margin = new Padding(3, 2, 3, 2);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(268, 22);
            btneliminar.TabIndex = 8;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnmodificar
            // 
            btnmodificar.Location = new Point(167, 172);
            btnmodificar.Margin = new Padding(3, 2, 3, 2);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(129, 22);
            btnmodificar.TabIndex = 7;
            btnmodificar.Text = "Modificar";
            btnmodificar.UseVisualStyleBackColor = true;
            btnmodificar.Click += btnmodificar_Click;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(28, 172);
            btnguardar.Margin = new Padding(3, 2, 3, 2);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(134, 22);
            btnguardar.TabIndex = 6;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(98, 80);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(183, 23);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 53);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(183, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(98, 26);
            txtCarnet.Margin = new Padding(3, 2, 3, 2);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(183, 23);
            txtCarnet.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 80);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 53);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 26);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Carnet";
            // 
            // dgvPersona
            // 
            dgvPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersona.Location = new Point(368, 30);
            dgvPersona.Margin = new Padding(3, 2, 3, 2);
            dgvPersona.Name = "dgvPersona";
            dgvPersona.RowHeadersWidth = 51;
            dgvPersona.Size = new Size(616, 244);
            dgvPersona.TabIndex = 1;
            dgvPersona.CellDoubleClick += dgvPersona_CellDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMonto);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtIdCuenta);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtTipo);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btneliminarcuenta);
            groupBox2.Controls.Add(btnmodificarcuenta);
            groupBox2.Controls.Add(btnguardarcuenta);
            groupBox2.Controls.Add(txtCarnett);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(24, 306);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(328, 244);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "cuentaBancaria";
            // 
            // txtIdCuenta
            // 
            txtIdCuenta.Enabled = false;
            txtIdCuenta.Location = new Point(113, 60);
            txtIdCuenta.Margin = new Padding(3, 2, 3, 2);
            txtIdCuenta.Name = "txtIdCuenta";
            txtIdCuenta.Size = new Size(183, 23);
            txtIdCuenta.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 60);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 11;
            label5.Text = "Id de cuenta";
            label5.Click += label5_Click;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(113, 125);
            txtTipo.Margin = new Padding(3, 2, 3, 2);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(183, 23);
            txtTipo.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 133);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 9;
            label7.Text = "Tipo de cuenta";
            // 
            // btneliminarcuenta
            // 
            btneliminarcuenta.Location = new Point(28, 198);
            btneliminarcuenta.Margin = new Padding(3, 2, 3, 2);
            btneliminarcuenta.Name = "btneliminarcuenta";
            btneliminarcuenta.Size = new Size(268, 22);
            btneliminarcuenta.TabIndex = 8;
            btneliminarcuenta.Text = "Eliminar";
            btneliminarcuenta.UseVisualStyleBackColor = true;
            btneliminarcuenta.Click += btneliminarcuenta_Click;
            // 
            // btnmodificarcuenta
            // 
            btnmodificarcuenta.Location = new Point(167, 172);
            btnmodificarcuenta.Margin = new Padding(3, 2, 3, 2);
            btnmodificarcuenta.Name = "btnmodificarcuenta";
            btnmodificarcuenta.Size = new Size(129, 22);
            btnmodificarcuenta.TabIndex = 7;
            btnmodificarcuenta.Text = "Modificar";
            btnmodificarcuenta.UseVisualStyleBackColor = true;
            btnmodificarcuenta.Click += btnmodificarcuenta_Click;
            // 
            // btnguardarcuenta
            // 
            btnguardarcuenta.Location = new Point(28, 172);
            btnguardarcuenta.Margin = new Padding(3, 2, 3, 2);
            btnguardarcuenta.Name = "btnguardarcuenta";
            btnguardarcuenta.Size = new Size(134, 22);
            btnguardarcuenta.TabIndex = 6;
            btnguardarcuenta.Text = "Guardar";
            btnguardarcuenta.UseVisualStyleBackColor = true;
            btnguardarcuenta.Click += btnguardarcuenta_Click;
            // 
            // txtCarnett
            // 
            txtCarnett.Location = new Point(113, 28);
            txtCarnett.Margin = new Padding(3, 2, 3, 2);
            txtCarnett.Name = "txtCarnett";
            txtCarnett.Size = new Size(183, 23);
            txtCarnett.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 28);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 0;
            label10.Text = "Carnet";
            // 
            // dgvCuenta
            // 
            dgvCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuenta.Location = new Point(380, 306);
            dgvCuenta.Margin = new Padding(3, 2, 3, 2);
            dgvCuenta.Name = "dgvCuenta";
            dgvCuenta.RowHeadersWidth = 51;
            dgvCuenta.Size = new Size(616, 244);
            dgvCuenta.TabIndex = 14;
            dgvCuenta.CellDoubleClick += dgvCuenta_CellDoubleClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 100);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 13;
            label6.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(113, 92);
            txtMonto.Margin = new Padding(3, 2, 3, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(183, 23);
            txtMonto.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 598);
            Controls.Add(dgvCuenta);
            Controls.Add(groupBox2);
            Controls.Add(dgvPersona);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersona).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btneliminar;
        private Button btnmodificar;
        private Button btnguardar;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtCarnet;
        private Label label3;
        private Label label2;
        private DataGridView dgvPersona;
        private TextBox txtDepartamento;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox txtTipo;
        private Label label7;
        private Button btneliminarcuenta;
        private Button btnmodificarcuenta;
        private Button btnguardarcuenta;
        private TextBox textBox5;
        private Label label10;
        private TextBox txtCarnett;
        private DataGridView dgvCuenta;
        private Label label5;
        private TextBox txtIdCuenta;
        private TextBox txtMonto;
        private Label label6;
    }
}
