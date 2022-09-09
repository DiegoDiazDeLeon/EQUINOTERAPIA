namespace Equinoterapia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.agregaUsuario = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.TextBox();
            this.EliminarCita = new System.Windows.Forms.Button();
            this.Curp = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelCurp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEdadCaballo = new System.Windows.Forms.TextBox();
            this.textBoxPesoCaballo = new System.Windows.Forms.TextBox();
            this.textBoxNombreCaballo = new System.Windows.Forms.TextBox();
            this.AgregaCaballo = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelFechaInicioCaballo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // agregaUsuario
            // 
            this.agregaUsuario.Location = new System.Drawing.Point(557, 176);
            this.agregaUsuario.Name = "agregaUsuario";
            this.agregaUsuario.Size = new System.Drawing.Size(100, 36);
            this.agregaUsuario.TabIndex = 0;
            this.agregaUsuario.Text = "Agrega Usuario";
            this.agregaUsuario.UseVisualStyleBackColor = true;
            this.agregaUsuario.Click += new System.EventHandler(this.CrearCita_Click);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(557, 28);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 2;
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(557, 64);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(100, 20);
            this.Apellido.TabIndex = 3;
            // 
            // Edad
            // 
            this.Edad.Location = new System.Drawing.Point(557, 100);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(100, 20);
            this.Edad.TabIndex = 4;
            // 
            // EliminarCita
            // 
            this.EliminarCita.Location = new System.Drawing.Point(688, 410);
            this.EliminarCita.Name = "EliminarCita";
            this.EliminarCita.Size = new System.Drawing.Size(100, 28);
            this.EliminarCita.TabIndex = 5;
            this.EliminarCita.Text = "Eliminar Cita";
            this.EliminarCita.UseVisualStyleBackColor = true;
            // 
            // Curp
            // 
            this.Curp.Location = new System.Drawing.Point(557, 135);
            this.Curp.Name = "Curp";
            this.Curp.Size = new System.Drawing.Size(100, 20);
            this.Curp.TabIndex = 6;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(477, 28);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(477, 64);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(47, 13);
            this.labelApellido.TabIndex = 8;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(480, 100);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(35, 13);
            this.labelEdad.TabIndex = 9;
            this.labelEdad.Text = "Edad:";
            // 
            // labelCurp
            // 
            this.labelCurp.AutoSize = true;
            this.labelCurp.Location = new System.Drawing.Point(483, 135);
            this.labelCurp.Name = "labelCurp";
            this.labelCurp.Size = new System.Drawing.Size(32, 13);
            this.labelCurp.TabIndex = 10;
            this.labelCurp.Text = "Curp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Edad:";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(226, 64);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(34, 13);
            this.labelPeso.TabIndex = 17;
            this.labelPeso.Text = "Peso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre:";
            // 
            // textBoxEdadCaballo
            // 
            this.textBoxEdadCaballo.Location = new System.Drawing.Point(314, 100);
            this.textBoxEdadCaballo.Name = "textBoxEdadCaballo";
            this.textBoxEdadCaballo.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdadCaballo.TabIndex = 14;
            // 
            // textBoxPesoCaballo
            // 
            this.textBoxPesoCaballo.Location = new System.Drawing.Point(314, 64);
            this.textBoxPesoCaballo.Name = "textBoxPesoCaballo";
            this.textBoxPesoCaballo.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesoCaballo.TabIndex = 13;
            // 
            // textBoxNombreCaballo
            // 
            this.textBoxNombreCaballo.Location = new System.Drawing.Point(314, 28);
            this.textBoxNombreCaballo.Name = "textBoxNombreCaballo";
            this.textBoxNombreCaballo.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreCaballo.TabIndex = 12;
            // 
            // AgregaCaballo
            // 
            this.AgregaCaballo.Location = new System.Drawing.Point(314, 176);
            this.AgregaCaballo.Name = "AgregaCaballo";
            this.AgregaCaballo.Size = new System.Drawing.Size(100, 24);
            this.AgregaCaballo.TabIndex = 11;
            this.AgregaCaballo.Text = "Agrega Caballo";
            this.AgregaCaballo.UseVisualStyleBackColor = true;
            this.AgregaCaballo.Click += new System.EventHandler(this.AgregaCaballo_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(314, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // labelFechaInicioCaballo
            // 
            this.labelFechaInicioCaballo.AutoSize = true;
            this.labelFechaInicioCaballo.Location = new System.Drawing.Point(229, 132);
            this.labelFechaInicioCaballo.Name = "labelFechaInicioCaballo";
            this.labelFechaInicioCaballo.Size = new System.Drawing.Size(82, 13);
            this.labelFechaInicioCaballo.TabIndex = 20;
            this.labelFechaInicioCaballo.Text = "Fecha de inicio:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFechaInicioCaballo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEdadCaballo);
            this.Controls.Add(this.textBoxPesoCaballo);
            this.Controls.Add(this.textBoxNombreCaballo);
            this.Controls.Add(this.AgregaCaballo);
            this.Controls.Add(this.labelCurp);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.Curp);
            this.Controls.Add(this.EliminarCita);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.agregaUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregaUsuario;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Edad;
        private System.Windows.Forms.Button EliminarCita;
        private System.Windows.Forms.TextBox Curp;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelCurp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEdadCaballo;
        private System.Windows.Forms.TextBox textBoxPesoCaballo;
        private System.Windows.Forms.TextBox textBoxNombreCaballo;
        private System.Windows.Forms.Button AgregaCaballo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelFechaInicioCaballo;
    }
}

