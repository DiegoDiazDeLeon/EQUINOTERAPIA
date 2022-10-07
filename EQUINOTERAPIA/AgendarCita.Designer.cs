namespace EQUINOTERAPIA
{
    partial class AgendarCita
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
            this.monthCalendar_fecha = new System.Windows.Forms.MonthCalendar();
            this.comboBox1_CURP = new System.Windows.Forms.ComboBox();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.comboBox_Hora = new System.Windows.Forms.ComboBox();
            this.label_Horario = new System.Windows.Forms.Label();
            this.textBox_Notas = new System.Windows.Forms.TextBox();
            this.label_Notas = new System.Windows.Forms.Label();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.comboBox_Caballo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_CURP
            // 
            this.label_CURP.AutoSize = true;
            this.label_CURP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CURP.Location = new System.Drawing.Point(15, 73);
            this.label_CURP.Name = "label_CURP";
            this.label_CURP.Size = new System.Drawing.Size(66, 24);
            this.label_CURP.TabIndex = 0;
            this.label_CURP.Text = "CURP:";
            // 
            // monthCalendar_fecha
            // 
            this.monthCalendar_fecha.Location = new System.Drawing.Point(282, 73);
            this.monthCalendar_fecha.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.monthCalendar_fecha.Name = "monthCalendar_fecha";
            this.monthCalendar_fecha.TabIndex = 1;
            // 
            // comboBox1_CURP
            // 
            this.comboBox1_CURP.FormattingEnabled = true;
            this.comboBox1_CURP.Location = new System.Drawing.Point(96, 73);
            this.comboBox1_CURP.Name = "comboBox1_CURP";
            this.comboBox1_CURP.Size = new System.Drawing.Size(166, 23);
            this.comboBox1_CURP.TabIndex = 2;
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.Location = new System.Drawing.Point(12, 117);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(78, 24);
            this.label_Nombre.TabIndex = 3;
            this.label_Nombre.Text = "Caballo:";
            // 
            // comboBox_Hora
            // 
            this.comboBox_Hora.FormattingEnabled = true;
            this.comboBox_Hora.Location = new System.Drawing.Point(96, 165);
            this.comboBox_Hora.Name = "comboBox_Hora";
            this.comboBox_Hora.Size = new System.Drawing.Size(166, 23);
            this.comboBox_Hora.TabIndex = 5;
            // 
            // label_Horario
            // 
            this.label_Horario.AutoSize = true;
            this.label_Horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Horario.Location = new System.Drawing.Point(12, 165);
            this.label_Horario.Name = "label_Horario";
            this.label_Horario.Size = new System.Drawing.Size(77, 24);
            this.label_Horario.TabIndex = 6;
            this.label_Horario.Text = "Horario:";
            // 
            // textBox_Notas
            // 
            this.textBox_Notas.Location = new System.Drawing.Point(16, 259);
            this.textBox_Notas.Multiline = true;
            this.textBox_Notas.Name = "textBox_Notas";
            this.textBox_Notas.Size = new System.Drawing.Size(514, 169);
            this.textBox_Notas.TabIndex = 7;
            // 
            // label_Notas
            // 
            this.label_Notas.AutoSize = true;
            this.label_Notas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Notas.Location = new System.Drawing.Point(15, 222);
            this.label_Notas.Name = "label_Notas";
            this.label_Notas.Size = new System.Drawing.Size(63, 24);
            this.label_Notas.TabIndex = 8;
            this.label_Notas.Text = "Notas:";
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.BackColor = System.Drawing.Color.LimeGreen;
            this.button_Aceptar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Aceptar.Location = new System.Drawing.Point(58, 446);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(177, 48);
            this.button_Aceptar.TabIndex = 30;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = false;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.BackColor = System.Drawing.Color.Brown;
            this.button_Cancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancelar.Location = new System.Drawing.Point(282, 446);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(177, 48);
            this.button_Cancelar.TabIndex = 29;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = false;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // comboBox_Caballo
            // 
            this.comboBox_Caballo.FormattingEnabled = true;
            this.comboBox_Caballo.Location = new System.Drawing.Point(96, 117);
            this.comboBox_Caballo.Name = "comboBox_Caballo";
            this.comboBox_Caballo.Size = new System.Drawing.Size(166, 23);
            this.comboBox_Caballo.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(164, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "AGREGAR CITA";
            // 
            // AgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(547, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Caballo);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.label_Notas);
            this.Controls.Add(this.textBox_Notas);
            this.Controls.Add(this.label_Horario);
            this.Controls.Add(this.comboBox_Hora);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.comboBox1_CURP);
            this.Controls.Add(this.monthCalendar_fecha);
            this.Controls.Add(this.label_CURP);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AgendarCita";
            this.Text = "AgendarCita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CURP;
        private System.Windows.Forms.MonthCalendar monthCalendar_fecha;
        private System.Windows.Forms.ComboBox comboBox1_CURP;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.ComboBox comboBox_Hora;
        private System.Windows.Forms.Label label_Horario;
        private System.Windows.Forms.TextBox textBox_Notas;
        private System.Windows.Forms.Label label_Notas;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.ComboBox comboBox_Caballo;
        private System.Windows.Forms.Label label1;
    }
}