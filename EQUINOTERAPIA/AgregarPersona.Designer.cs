namespace EQUINOTERAPIA
{
    partial class AgregarPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_CURP = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_correo = new System.Windows.Forms.Label();
            this.label_Numero = new System.Windows.Forms.Label();
            this.label_Nacimiento = new System.Windows.Forms.Label();
            this.textBox_CURP = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Correo = new System.Windows.Forms.TextBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.dateTimePicker_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label_Notas = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_CURP
            // 
            this.label_CURP.AutoSize = true;
            this.label_CURP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CURP.Location = new System.Drawing.Point(12, 9);
            this.label_CURP.Name = "label_CURP";
            this.label_CURP.Size = new System.Drawing.Size(66, 24);
            this.label_CURP.TabIndex = 1;
            this.label_CURP.Text = "CURP:";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(12, 48);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(84, 24);
            this.label_nombre.TabIndex = 2;
            this.label_nombre.Text = "Nombre:";
            // 
            // label_correo
            // 
            this.label_correo.AutoSize = true;
            this.label_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_correo.Location = new System.Drawing.Point(12, 91);
            this.label_correo.Name = "label_correo";
            this.label_correo.Size = new System.Drawing.Size(73, 24);
            this.label_correo.TabIndex = 3;
            this.label_correo.Text = "Correo:";
            // 
            // label_Numero
            // 
            this.label_Numero.AutoSize = true;
            this.label_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Numero.Location = new System.Drawing.Point(454, 63);
            this.label_Numero.Name = "label_Numero";
            this.label_Numero.Size = new System.Drawing.Size(90, 24);
            this.label_Numero.TabIndex = 4;
            this.label_Numero.Text = "Telefono:";
            // 
            // label_Nacimiento
            // 
            this.label_Nacimiento.AutoSize = true;
            this.label_Nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nacimiento.Location = new System.Drawing.Point(454, 7);
            this.label_Nacimiento.Name = "label_Nacimiento";
            this.label_Nacimiento.Size = new System.Drawing.Size(196, 24);
            this.label_Nacimiento.TabIndex = 5;
            this.label_Nacimiento.Text = "Fecha de Nacimiento:";
            this.label_Nacimiento.Click += new System.EventHandler(this.label_Nacimiento_Click);
            // 
            // textBox_CURP
            // 
            this.textBox_CURP.Location = new System.Drawing.Point(127, 12);
            this.textBox_CURP.Name = "textBox_CURP";
            this.textBox_CURP.Size = new System.Drawing.Size(302, 20);
            this.textBox_CURP.TabIndex = 6;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(127, 52);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(302, 20);
            this.textBox_Nombre.TabIndex = 7;
            // 
            // textBox_Correo
            // 
            this.textBox_Correo.Location = new System.Drawing.Point(127, 96);
            this.textBox_Correo.Name = "textBox_Correo";
            this.textBox_Correo.Size = new System.Drawing.Size(302, 20);
            this.textBox_Correo.TabIndex = 8;
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Location = new System.Drawing.Point(458, 96);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(214, 20);
            this.textBox_telefono.TabIndex = 9;
            // 
            // dateTimePicker_nacimiento
            // 
            this.dateTimePicker_nacimiento.Location = new System.Drawing.Point(458, 34);
            this.dateTimePicker_nacimiento.Name = "dateTimePicker_nacimiento";
            this.dateTimePicker_nacimiento.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker_nacimiento.TabIndex = 10;
            this.dateTimePicker_nacimiento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label_Notas
            // 
            this.label_Notas.AutoSize = true;
            this.label_Notas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Notas.Location = new System.Drawing.Point(12, 125);
            this.label_Notas.Name = "label_Notas";
            this.label_Notas.Size = new System.Drawing.Size(63, 24);
            this.label_Notas.TabIndex = 11;
            this.label_Notas.Text = "Notas:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 166);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(684, 155);
            this.textBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(127, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(437, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 42);
            this.button2.TabIndex = 14;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AgregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 381);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Notas);
            this.Controls.Add(this.dateTimePicker_nacimiento);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.textBox_Correo);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.textBox_CURP);
            this.Controls.Add(this.label_Nacimiento);
            this.Controls.Add(this.label_Numero);
            this.Controls.Add(this.label_correo);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label_CURP);
            this.Name = "AgregarPersona";
            this.Text = "AgregarPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CURP;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_correo;
        private System.Windows.Forms.Label label_Numero;
        private System.Windows.Forms.Label label_Nacimiento;
        private System.Windows.Forms.TextBox textBox_CURP;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Correo;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.DateTimePicker dateTimePicker_nacimiento;
        private System.Windows.Forms.Label label_Notas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}