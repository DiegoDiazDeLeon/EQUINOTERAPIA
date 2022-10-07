using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;
using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Config;

namespace EQUINOTERAPIA
{
    public partial class AgendarCita : Form
    {
        public IFirebaseClient client;
        public AgendarCita()
        {

            InitializeComponent();
            config();
        }




            /*Metodo para cancelar el llenado de datos*/
            private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void config()
        {
            IFirebaseConfig fconfig = new FirebaseConfig
            {
                AuthSecret = "czGcy6xx0Rko6k6BiQSmreMXBJJveeTdNGQXYxrv",
                BasePath = "https://equinoterapia-d4038-default-rtdb.firebaseio.com/",
            };

            client = new FirebaseClient(fconfig);
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            var cit = monthCalendar_fecha.SelectionRange.Start.ToShortDateString();
            Citas citas = new Citas()
            {
                CURP = comboBox1_CURP.Text,
                Hora = comboBox_Hora.Text+":" +comboBoxMinutos.Text+""+comboBox1ampm.Text,
                id_Caballo = comboBox_Caballo.Text,
                fechaDeCita = DateTime.Parse(cit),
                Notas= textBox_Notas.Text,
            };
            try
            {
                client.Set("Citas/" + comboBox1_CURP.Text, citas);
                MessageBox.Show("cita agendada con exito");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Incorrecta El añadir");
            }
        }
    }
}
