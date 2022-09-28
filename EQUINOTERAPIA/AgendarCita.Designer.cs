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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.comboBox1_CURP = new System.Windows.Forms.ComboBox();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_Horario = new System.Windows.Forms.Label();
            this.textBox_Notas = new System.Windows.Forms.TextBox();
            this.label_Notas = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_CURP
            // 
            this.label_CURP.AutoSize = true;
            this.label_CURP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CURP.Location = new System.Drawing.Point(12, 21);
            this.label_CURP.Name = "label_CURP";
            this.label_CURP.Size = new System.Drawing.Size(66, 24);
            this.label_CURP.TabIndex = 0;
            this.label_CURP.Text = "CURP:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(534, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // comboBox1_CURP
            // 
            this.comboBox1_CURP.FormattingEnabled = true;
            this.comboBox1_CURP.Location = new System.Drawing.Point(119, 21);
            this.comboBox1_CURP.Name = "comboBox1_CURP";
            this.comboBox1_CURP.Size = new System.Drawing.Size(388, 21);
            this.comboBox1_CURP.TabIndex = 2;
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.Location = new System.Drawing.Point(12, 66);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(84, 24);
            this.label_Nombre.TabIndex = 3;
            this.label_Nombre.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 20);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label_Horario
            // 
            this.label_Horario.AutoSize = true;
            this.label_Horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Horario.Location = new System.Drawing.Point(12, 111);
            this.label_Horario.Name = "label_Horario";
            this.label_Horario.Size = new System.Drawing.Size(77, 24);
            this.label_Horario.TabIndex = 6;
            this.label_Horario.Text = "Horario:";
            // 
            // textBox_Notas
            // 
            this.textBox_Notas.Location = new System.Drawing.Point(16, 224);
            this.textBox_Notas.Multiline = true;
            this.textBox_Notas.Name = "textBox_Notas";
            this.textBox_Notas.Size = new System.Drawing.Size(766, 147);
            this.textBox_Notas.TabIndex = 7;
            // 
            // label_Notas
            // 
            this.label_Notas.AutoSize = true;
            this.label_Notas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Notas.Location = new System.Drawing.Point(19, 180);
            this.label_Notas.Name = "label_Notas";
            this.label_Notas.Size = new System.Drawing.Size(63, 24);
            this.label_Notas.TabIndex = 8;
            this.label_Notas.Text = "Notas:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(466, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 42);
            this.button2.TabIndex = 30;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.BackColor = System.Drawing.Color.Red;
            this.button_Cancelar.Location = new System.Drawing.Point(156, 387);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(177, 42);
            this.button_Cancelar.TabIndex = 29;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = false;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // AgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.label_Notas);
            this.Controls.Add(this.textBox_Notas);
            this.Controls.Add(this.label_Horario);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.comboBox1_CURP);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label_CURP);
            this.Name = "AgendarCita";
            this.Text = "AgendarCita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CURP;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBox1_CURP;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_Horario;
        private System.Windows.Forms.TextBox textBox_Notas;
        private System.Windows.Forms.Label label_Notas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Cancelar;
    }
}