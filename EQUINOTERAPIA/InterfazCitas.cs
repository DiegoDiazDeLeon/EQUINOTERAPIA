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
        }
    }
}
