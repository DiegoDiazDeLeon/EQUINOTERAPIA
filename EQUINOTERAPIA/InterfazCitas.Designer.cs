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
            this.CITAS_ = new System.Windows.Forms.TabControl();
            this.CITAS = new System.Windows.Forms.TabPage();
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
            this.CITAS_.SuspendLayout();
            this.CITAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Citas)).BeginInit();
            this.SuspendLayout();
            // 
            // CITAS_
            // 
            this.CITAS_.Controls.Add(this.CITAS);
            this.CITAS_.Controls.Add(this.CABALLO_);
            this.CITAS_.Location = new System.Drawing.Point(12, 12);
            this.CITAS_.Name = "CITAS_";
            this.CITAS_.SelectedIndex = 0;
            this.CITAS_.Size = new System.Drawing.Size(1159, 582);
            this.CITAS_.TabIndex = 2;
            // 
            // CITAS
            // 
            this.CITAS.Controls.Add(this.button_eliminarCita);
            this.CITAS.Controls.Add(this.pictureBox1);
            this.CITAS.Controls.Add(this.label_CURP);
            this.CITAS.Controls.Add(this.button_Buscar);
            this.CITAS.Controls.Add(this.textBox_buscador);
            this.CITAS.Controls.Add(this.dataGridView_Citas);
            this.CITAS.Controls.Add(this.button_AgregarCita);
            this.CITAS.Location = new System.Drawing.Point(4, 22);
            this.CITAS.Name = "CITAS";
            this.CITAS.Padding = new System.Windows.Forms.Padding(3);
            this.CITAS.Size = new System.Drawing.Size(1151, 556);
            this.CITAS.TabIndex = 0;
            this.CITAS.Text = "CITAS";
            this.CITAS.UseVisualStyleBackColor = true;
            // 
            // button_eliminarCita
            // 
            this.button_eliminarCita.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.pictureBox1.Size = new System.Drawing.Size(94, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label_CURP
            // 
            this.label_CURP.AutoSize = true;
            this.label_CURP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CURP.Location = new System.Drawing.Point(127, 6);
            this.label_CURP.Name = "label_CURP";
            this.label_CURP.Size = new System.Drawing.Size(48, 16);
            this.label_CURP.TabIndex = 4;
            this.label_CURP.Text = "CURP:";
            // 
            // button_Buscar
            // 
            this.button_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("button_Buscar.Image")));
            this.button_Buscar.Location = new System.Drawing.Point(308, 6);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(52, 41);
            this.button_Buscar.TabIndex = 3;
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // textBox_buscador
            // 
            this.textBox_buscador.Location = new System.Drawing.Point(130, 23);
            this.textBox_buscador.Name = "textBox_buscador";
            this.textBox_buscador.Size = new System.Drawing.Size(172, 20);
            this.textBox_buscador.TabIndex = 2;
            // 
            // dataGridView_Citas
            // 
            this.dataGridView_Citas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Citas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CURP,
            this.Apellido,
            this.FECHA,
            this.Edad,
            this.NOTAS});
            this.dataGridView_Citas.Location = new System.Drawing.Point(21, 81);
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
            this.button_AgregarCita.BackColor = System.Drawing.Color.Lime;
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
            this.CABALLO_.Location = new System.Drawing.Point(4, 22);
            this.CABALLO_.Name = "CABALLO_";
            this.CABALLO_.Padding = new System.Windows.Forms.Padding(3);
            this.CABALLO_.Size = new System.Drawing.Size(1151, 556);
            this.CABALLO_.TabIndex = 1;
            this.CABALLO_.Text = "CABALLO";
            this.CABALLO_.UseVisualStyleBackColor = true;
            // 
            // InterfazCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 606);
            this.Controls.Add(this.CITAS_);
            this.Name = "InterfazCitas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.InterfazCitas_Load);
            this.CITAS_.ResumeLayout(false);
            this.CITAS.ResumeLayout(false);
            this.CITAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Citas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl CITAS_;
        private System.Windows.Forms.TabPage CITAS;
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
    }
}