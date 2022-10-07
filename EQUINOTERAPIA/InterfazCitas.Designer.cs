namespace EQUINOTERAPIA
{
    partial class InterfazCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazCitas));
            this.TabCitas = new System.Windows.Forms.TabControl();
            this.tab_CITAS = new System.Windows.Forms.TabPage();
            this.button_eliminarCita = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_CURP = new System.Windows.Forms.Label();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.textBox_buscador = new System.Windows.Forms.TextBox();
            this.dataGridView_Citas = new System.Windows.Forms.DataGridView();
            this.CURP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_AgregarCita = new System.Windows.Forms.Button();
            this.CABALLO_ = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Nombre_Participante = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.TabCitas.SuspendLayout();
            this.tab_CITAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Citas)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TabCitas
            // 
            this.TabCitas.Controls.Add(this.tab_CITAS);
            this.TabCitas.Controls.Add(this.CABALLO_);
            this.TabCitas.Controls.Add(this.tabPage1);
            this.TabCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCitas.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabCitas.Location = new System.Drawing.Point(0, 0);
            this.TabCitas.Margin = new System.Windows.Forms.Padding(0);
            this.TabCitas.Name = "TabCitas";
            this.TabCitas.SelectedIndex = 0;
            this.TabCitas.Size = new System.Drawing.Size(1183, 606);
            this.TabCitas.TabIndex = 7;
            // 
            // tab_CITAS
            // 
            this.tab_CITAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(147)))), ((int)(((byte)(196)))));
            this.tab_CITAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tab_CITAS.Controls.Add(this.button_eliminarCita);
            this.tab_CITAS.Controls.Add(this.pictureBox1);
            this.tab_CITAS.Controls.Add(this.label_CURP);
            this.tab_CITAS.Controls.Add(this.button_Buscar);
            this.tab_CITAS.Controls.Add(this.textBox_buscador);
            this.tab_CITAS.Controls.Add(this.dataGridView_Citas);
            this.tab_CITAS.Controls.Add(this.button_AgregarCita);
            this.tab_CITAS.ForeColor = System.Drawing.Color.Black;
            this.tab_CITAS.Location = new System.Drawing.Point(4, 23);
            this.tab_CITAS.Margin = new System.Windows.Forms.Padding(0);
            this.tab_CITAS.Name = "tab_CITAS";
            this.tab_CITAS.Size = new System.Drawing.Size(1175, 579);
            this.tab_CITAS.TabIndex = 0;
            this.tab_CITAS.Text = "CITAS";
            // 
            // button_eliminarCita
            // 
            this.button_eliminarCita.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_eliminarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminarCita.ForeColor = System.Drawing.Color.Black;
            this.button_eliminarCita.Image = ((System.Drawing.Image)(resources.GetObject("button_eliminarCita.Image")));
            this.button_eliminarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_eliminarCita.Location = new System.Drawing.Point(995, 21);
            this.button_eliminarCita.Name = "button_eliminarCita";
            this.button_eliminarCita.Size = new System.Drawing.Size(140, 54);
            this.button_eliminarCita.TabIndex = 6;
            this.button_eliminarCita.Text = "Eliminar Cita";
            this.button_eliminarCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_eliminarCita.UseVisualStyleBackColor = false;
            this.button_eliminarCita.Click += new System.EventHandler(this.button_eliminarCita_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label_CURP
            // 
            this.label_CURP.AutoSize = true;
            this.label_CURP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CURP.ForeColor = System.Drawing.Color.White;
            this.label_CURP.Location = new System.Drawing.Point(147, 18);
            this.label_CURP.Name = "label_CURP";
            this.label_CURP.Size = new System.Drawing.Size(78, 25);
            this.label_CURP.TabIndex = 4;
            this.label_CURP.Text = "CURP:";
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(333, 49);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(21, 20);
            this.button_Buscar.TabIndex = 3;
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // textBox_buscador
            // 
            this.textBox_buscador.Location = new System.Drawing.Point(155, 49);
            this.textBox_buscador.Name = "textBox_buscador";
            this.textBox_buscador.Size = new System.Drawing.Size(172, 20);
            this.textBox_buscador.TabIndex = 2;
            // 
            // dataGridView_Citas
            // 
            this.dataGridView_Citas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Citas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Citas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CURP,
            this.Apellido,
            this.FECHA,
            this.Edad,
            this.NOTAS});
            this.dataGridView_Citas.Location = new System.Drawing.Point(21, 95);
            this.dataGridView_Citas.Name = "dataGridView_Citas";
            this.dataGridView_Citas.Size = new System.Drawing.Size(1114, 452);
            this.dataGridView_Citas.TabIndex = 1;
            this.dataGridView_Citas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Citas_RowHeaderMouseClick);
            // 
            // CURP
            // 
            this.CURP.HeaderText = "CURP";
            this.CURP.Name = "CURP";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "CABALLO";
            this.Apellido.Name = "Apellido";
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "HORA";
            this.Edad.Name = "Edad";
            // 
            // NOTAS
            // 
            this.NOTAS.HeaderText = "NOTAS";
            this.NOTAS.Name = "NOTAS";
            // 
            // button_AgregarCita
            // 
            this.button_AgregarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(0)))));
            this.button_AgregarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AgregarCita.ForeColor = System.Drawing.Color.Black;
            this.button_AgregarCita.Image = ((System.Drawing.Image)(resources.GetObject("button_AgregarCita.Image")));
            this.button_AgregarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AgregarCita.Location = new System.Drawing.Point(839, 21);
            this.button_AgregarCita.Name = "button_AgregarCita";
            this.button_AgregarCita.Size = new System.Drawing.Size(140, 54);
            this.button_AgregarCita.TabIndex = 0;
            this.button_AgregarCita.Text = "Agregar Cita";
            this.button_AgregarCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_AgregarCita.UseVisualStyleBackColor = false;
            this.button_AgregarCita.Click += new System.EventHandler(this.button_AgregarCita_Click_1);
            // 
            // CABALLO_
            // 
            this.CABALLO_.Location = new System.Drawing.Point(4, 23);
            this.CABALLO_.Name = "CABALLO_";
            this.CABALLO_.Padding = new System.Windows.Forms.Padding(3);
            this.CABALLO_.Size = new System.Drawing.Size(1175, 579);
            this.CABALLO_.TabIndex = 1;
            this.CABALLO_.Text = "CABALLO";
            this.CABALLO_.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(147)))), ((int)(((byte)(196)))));
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1175, 579);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "COLABORADORES";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.Nombre_Participante);
            this.groupBox1.Location = new System.Drawing.Point(586, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 452);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualiza Colaborador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Semestre";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Trabajador",
            "Servicio Social",
            "Donantes",
            "Instituciones",
            "Voluntarios",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(37, 251);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Carrera";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(229, 353);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(37, 332);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(37, 152);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefono";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(37, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correo Electronico";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Nombre_Participante
            // 
            this.Nombre_Participante.AutoSize = true;
            this.Nombre_Participante.Location = new System.Drawing.Point(34, 36);
            this.Nombre_Participante.Name = "Nombre_Participante";
            this.Nombre_Participante.Size = new System.Drawing.Size(51, 14);
            this.Nombre_Participante.TabIndex = 0;
            this.Nombre_Participante.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 20);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "CURP:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.NOMBRE});
            this.dataGridView1.Location = new System.Drawing.Point(21, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(379, 452);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "CURP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(37, 391);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 22);
            this.comboBox2.TabIndex = 13;
            // 
            // InterfazCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1183, 606);
            this.Controls.Add(this.TabCitas);
            this.Name = "InterfazCitas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.InterfazCitas_Load);
            this.TabCitas.ResumeLayout(false);
            this.tab_CITAS.ResumeLayout(false);
            this.tab_CITAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Citas)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tab_CITAS;
        private System.Windows.Forms.TabPage CABALLO_;
        private System.Windows.Forms.DataGridView dataGridView_Citas;
        private System.Windows.Forms.Button button_AgregarCita;
        private System.Windows.Forms.Label label_CURP;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.TextBox textBox_buscador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTAS;
        private System.Windows.Forms.Button button_eliminarCita;
        private System.Windows.Forms.TabControl TabCitas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.Label Nombre_Participante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}