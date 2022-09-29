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
    public partial class InterfazCitas : Form
    {
        public IFirebaseClient client;
        public InterfazCitas()
        {
            InitializeComponent();
            config();
            MostrarCitas();
            
        }

        private void button_AgregarCita_Click(object sender, EventArgs e)
        {
            //Crea un form de tipo agendar cita y lo muestra
            AgendarCita agendarCita = new AgendarCita();
            agendarCita.Show();
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

        /*
        private void MostrarCitas()
        {
            FirebaseResponse response = client.Get("BENEFES/");
            Dictionary<string, Equinoterapia.Beneficiarios> getBeneficiarios = response.ResultAs<Dictionary<string,Equinoterapia.Beneficiarios>>();
            //var get in getBeneficiarios;
            foreach (var get in getBeneficiarios)
            {
                dataGridView_Citas.Rows.Add(

                    get.Value.nombre,
                    get.Value.apellido,
                    Convert.ToString(get.Value.edad)
                );
            }
        }*/

        private void MostrarCitas()
        {
            dataGridView_Citas.Columns[0].HeaderText = "Notas";
            dataGridView_Citas.Columns[1].HeaderText = "Hora";
            dataGridView_Citas.Columns[2].HeaderText = "CURP";
            dataGridView_Citas.Columns[3].HeaderText = "ID Caballo";
            dataGridView_Citas.Columns[4].HeaderText = "Fecha de cita";



            //Se conecta a la DB a
            FirebaseResponse response = client.Get("Citas/");
            //Identifica las variables de la clase citas con un id de la base de datos
            Dictionary<string, Citas> getCitas = response.ResultAs<Dictionary<string, Citas>>();
            //var get in getBeneficiarios;
            foreach (var get in getCitas)
            {
                dataGridView_Citas.Rows.Add(

                    get.Value.Notas,
                    get.Value.Hora,
                    get.Value.CURP,
                    get.Value.id_Caballo,
                    get.Value.fechaDeCita
                );
            }
        }

        private void InterfazCitas_Load(object sender, EventArgs e)
        {

        }
    }
}
