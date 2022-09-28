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
            this.EliminarBeneficiario = new System.Windows.Forms.Button();
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
            this.ActualizaBeneficiario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // agregaUsuario
            // 
            this.agregaUsuario.Location = new System.Drawing.Point(557, 176);
            this.agregaUsuario.Name = "agregaUsuario";
            this.agregaUsuario.Size = new System.Drawing.Size(110, 36);
            this.agregaUsuario.TabIndex = 0;
            this.agregaUsuario.Text = "Agrega Beneficiario";
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
            // EliminarBeneficiario
            // 
            this.EliminarBeneficiario.Location = new System.Drawing.Point(557, 230);
            this.EliminarBeneficiario.Name = "EliminarBeneficiario";
            this.EliminarBeneficiario.Size = new System.Drawing.Size(110, 28);
            this.EliminarBeneficiario.TabIndex = 5;
            this.EliminarBeneficiario.Text = "Eliminar Beneficiario";
            this.EliminarBeneficiario.UseVisualStyleBackColor = true;
            this.EliminarBeneficiario.Click += new System.EventHandler(this.EliminarBeneficiario_Click);
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
            this.label2.Location = new System.Drawing.Point(21, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Edad:";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(21, 64);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(34, 13);
            this.labelPeso.TabIndex = 17;
            this.labelPeso.Text = "Peso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre:";
            // 
            // textBoxEdadCaballo
            // 
            this.textBoxEdadCaballo.Location = new System.Drawing.Point(74, 97);
            this.textBoxEdadCaballo.Name = "textBoxEdadCaballo";
            this.textBoxEdadCaballo.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdadCaballo.TabIndex = 14;
            // 
            // textBoxPesoCaballo
            // 
            this.textBoxPesoCaballo.Location = new System.Drawing.Point(74, 61);
            this.textBoxPesoCaballo.Name = "textBoxPesoCaballo";
            this.textBoxPesoCaballo.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesoCaballo.TabIndex = 13;
            // 
            // textBoxNombreCaballo
            // 
            this.textBoxNombreCaballo.Location = new System.Drawing.Point(74, 28);
            this.textBoxNombreCaballo.Name = "textBoxNombreCaballo";
            this.textBoxNombreCaballo.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreCaballo.TabIndex = 12;
            // 
            // AgregaCaballo
            // 
            this.AgregaCaballo.Location = new System.Drawing.Point(65, 182);
            this.AgregaCaballo.Name = "AgregaCaballo";
            this.AgregaCaballo.Size = new System.Drawing.Size(100, 24);
            this.AgregaCaballo.TabIndex = 11;
            this.AgregaCaballo.Text = "Agrega Caballo";
            this.AgregaCaballo.UseVisualStyleBackColor = true;
            this.AgregaCaballo.Click += new System.EventHandler(this.AgregaCaballo_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // labelFechaInicioCaballo
            // 
            this.labelFechaInicioCaballo.AutoSize = true;
            this.labelFechaInicioCaballo.Location = new System.Drawing.Point(21, 139);
            this.labelFechaInicioCaballo.Name = "labelFechaInicioCaballo";
            this.labelFechaInicioCaballo.Size = new System.Drawing.Size(82, 13);
            this.labelFechaInicioCaballo.TabIndex = 20;
            this.labelFechaInicioCaballo.Text = "Fecha de inicio:";
            // 
            // ActualizaBeneficiario
            // 
            this.ActualizaBeneficiario.Location = new System.Drawing.Point(557, 278);
            this.ActualizaBeneficiario.Name = "ActualizaBeneficiario";
            this.ActualizaBeneficiario.Size = new System.Drawing.Size(123, 28);
            this.ActualizaBeneficiario.TabIndex = 21;
            this.ActualizaBeneficiario.Text = "Actualiza Beneficiario";
            this.ActualizaBeneficiario.UseVisualStyleBackColor = true;
            this.ActualizaBeneficiario.Click += new System.EventHandler(this.ActualizaBeneficiario_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 36);
            this.button1.TabIndex = 22;
            this.button1.Text = "Visualiza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ActualizaBeneficiario);
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
            this.Controls.Add(this.EliminarBeneficiario);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.agregaUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregaUsuario;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Edad;
        private System.Windows.Forms.Button EliminarBeneficiario;
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
        private System.Windows.Forms.Button ActualizaBeneficiario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

