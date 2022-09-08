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
            this.CrearCita = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CrearCita
            // 
            this.CrearCita.Location = new System.Drawing.Point(557, 135);
            this.CrearCita.Name = "CrearCita";
            this.CrearCita.Size = new System.Drawing.Size(100, 36);
            this.CrearCita.TabIndex = 0;
            this.CrearCita.Text = "crear cita";
            this.CrearCita.UseVisualStyleBackColor = true;
            this.CrearCita.Click += new System.EventHandler(this.CrearCita_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.CrearCita);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CrearCita;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Edad;
    }
}

