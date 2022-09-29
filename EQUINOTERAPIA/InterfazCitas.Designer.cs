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
            this.ta1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_CURP = new System.Windows.Forms.Label();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView_Citas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_AgregarCita = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ta1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Citas)).BeginInit();
            this.SuspendLayout();
            // 
            // ta1
            // 
            this.ta1.Controls.Add(this.tabPage1);
            this.ta1.Controls.Add(this.tabPage2);
            this.ta1.Location = new System.Drawing.Point(12, 12);
            this.ta1.Name = "ta1";
            this.ta1.SelectedIndex = 0;
            this.ta1.Size = new System.Drawing.Size(1159, 582);
            this.ta1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label_CURP);
            this.tabPage1.Controls.Add(this.button_Buscar);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dataGridView_Citas);
            this.tabPage1.Controls.Add(this.button_AgregarCita);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1151, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView_Citas
            // 
            this.dataGridView_Citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Citas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Edad});
            this.dataGridView_Citas.Location = new System.Drawing.Point(21, 81);
            this.dataGridView_Citas.Name = "dataGridView_Citas";
            this.dataGridView_Citas.Size = new System.Drawing.Size(1114, 452);
            this.dataGridView_Citas.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // button_AgregarCita
            // 
            this.button_AgregarCita.BackColor = System.Drawing.Color.Lime;
            this.button_AgregarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AgregarCita.ForeColor = System.Drawing.Color.Black;
            this.button_AgregarCita.Image = ((System.Drawing.Image)(resources.GetObject("button_AgregarCita.Image")));
            this.button_AgregarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AgregarCita.Location = new System.Drawing.Point(995, 23);
            this.button_AgregarCita.Name = "button_AgregarCita";
            this.button_AgregarCita.Size = new System.Drawing.Size(140, 54);
            this.button_AgregarCita.TabIndex = 0;
            this.button_AgregarCita.Text = "Agregar Cita";
            this.button_AgregarCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_AgregarCita.UseVisualStyleBackColor = false;
            this.button_AgregarCita.Click += new System.EventHandler(this.button_AgregarCita_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1151, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // InterfazCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 606);
            this.Controls.Add(this.ta1);
            this.Name = "InterfazCitas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.InterfazCitas_Load);
            this.ta1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Citas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl ta1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView_Citas;
        private System.Windows.Forms.Button button_AgregarCita;
        private System.Windows.Forms.Label label_CURP;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
    }
}