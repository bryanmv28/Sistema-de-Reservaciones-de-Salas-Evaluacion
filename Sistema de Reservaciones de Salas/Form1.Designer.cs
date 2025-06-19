namespace Reservaciones
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreSala = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.btnAgregarSala = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarReservacion = new System.Windows.Forms.Button();
            this.comboBoxSalas = new System.Windows.Forms.ComboBox();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacidad:";
            // 
            // txtNombreSala
            // 
            this.txtNombreSala.Location = new System.Drawing.Point(196, 14);
            this.txtNombreSala.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtNombreSala.Name = "txtNombreSala";
            this.txtNombreSala.Size = new System.Drawing.Size(527, 39);
            this.txtNombreSala.TabIndex = 2;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(196, 69);
            this.txtCapacidad.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(527, 39);
            this.txtCapacidad.TabIndex = 3;
            // 
            // btnAgregarSala
            // 
            this.btnAgregarSala.Location = new System.Drawing.Point(345, 110);
            this.btnAgregarSala.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnAgregarSala.Name = "btnAgregarSala";
            this.btnAgregarSala.Size = new System.Drawing.Size(199, 46);
            this.btnAgregarSala.TabIndex = 4;
            this.btnAgregarSala.Text = "Agregar Sala";
            this.btnAgregarSala.UseVisualStyleBackColor = true;
            this.btnAgregarSala.Click += new System.EventHandler(this.btnAgregarSala_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(196, 191);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(527, 39);
            this.txtNombreCliente.TabIndex = 7;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(196, 255);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(527, 39);
            this.txtCorreo.TabIndex = 8;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(345, 296);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(199, 44);
            this.btnAgregarCliente.TabIndex = 9;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 364);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sala:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 428);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 492);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(196, 484);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(527, 39);
            this.dtpFecha.TabIndex = 15;
            // 
            // btnAgregarReservacion
            // 
            this.btnAgregarReservacion.Location = new System.Drawing.Point(345, 530);
            this.btnAgregarReservacion.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnAgregarReservacion.Name = "btnAgregarReservacion";
            this.btnAgregarReservacion.Size = new System.Drawing.Size(199, 50);
            this.btnAgregarReservacion.TabIndex = 16;
            this.btnAgregarReservacion.Text = "Reservar";
            this.btnAgregarReservacion.UseVisualStyleBackColor = true;
            this.btnAgregarReservacion.Click += new System.EventHandler(this.btnAgregarReservacion_Click);
            // 
            // comboBoxSalas
            // 
            this.comboBoxSalas.FormattingEnabled = true;
            this.comboBoxSalas.Location = new System.Drawing.Point(196, 356);
            this.comboBoxSalas.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.comboBoxSalas.Name = "comboBoxSalas";
            this.comboBoxSalas.Size = new System.Drawing.Size(527, 40);
            this.comboBoxSalas.TabIndex = 17;
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(196, 420);
            this.comboBoxClientes.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(527, 40);
            this.comboBoxClientes.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 597);
            this.Controls.Add(this.comboBoxClientes);
            this.Controls.Add(this.comboBoxSalas);
            this.Controls.Add(this.btnAgregarReservacion);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregarSala);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtNombreSala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Form1";
            this.Text = "Sistema de Reservaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreSala;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Button btnAgregarSala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnAgregarReservacion;
        private System.Windows.Forms.ComboBox comboBoxSalas;
        private System.Windows.Forms.ComboBox comboBoxClientes;
    }
}