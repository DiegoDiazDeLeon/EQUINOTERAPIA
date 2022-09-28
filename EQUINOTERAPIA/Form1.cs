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

namespace Equinoterapia
{
    
    public partial class Form1 : Form
    {
        public IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
            config();

        }

        /*
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client= new FireSharp.FirebaseClient(fconfig);
            }
            catch
            {
                MessageBox.Show("Error en Base");
            }
        }
        */
        
        private void config()
        {


            IFirebaseConfig fconfig = new FirebaseConfig
            {
                AuthSecret = "czGcy6xx0Rko6k6BiQSmreMXBJJveeTdNGQXYxrv",
                BasePath = "https://equinoterapia-d4038-default-rtdb.firebaseio.com/",
            };

            client = new FirebaseClient(fconfig);

        }

        private void CrearCita_Click(object sender, EventArgs e)
        {
            Beneficiarios bnf = new Beneficiarios()
            {
                nombre = Nombre.Text,
                apellido = Apellido.Text,
                edad= Convert.ToInt32(Edad.Text),
                curp = Curp.Text,

            };
            try
            {
                client.Set("BENEFES/" + Nombre.Text, bnf);
                MessageBox.Show("correcto");
            }
            catch
            {
                MessageBox.Show("Incorrecta El añadir");
            }
            
        }

        private void AgregaCaballo_Click(object sender, EventArgs e)
        {
            Caballo caballo = new Caballo()
            {
                nombre = textBoxNombreCaballo.Text,
                edad = Int32.Parse(textBoxEdadCaballo.Text),
                peso = Int32.Parse(textBoxPesoCaballo.Text),
                fechaInicio = dateTimePicker1.Value,
            };
            client.Set("CABALLO/" + caballo.nombre, caballo);
            MessageBox.Show("correcto");
        }

        private void EliminarBeneficiario_Click(object sender, EventArgs e)
        {
            client.Delete("BENEFES/" + Nombre.Text);
            MessageBox.Show("correcto el usuario"+Nombre.Text+"ah Sido eliminado");
        }

        private void ActualizaBeneficiario_Click(object sender, EventArgs e)
        {
            Beneficiarios bnf = new Beneficiarios()
            {
                nombre = Nombre.Text,
                apellido = Apellido.Text,
                edad = Convert.ToInt32(Edad.Text),
                curp = Curp.Text,
            };
            client.Update("BENEFES/" + Nombre.Text, bnf);
            MessageBox.Show("correcto se han actualizado Datos");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            FirebaseResponse response =client.Get("BENEFES/");
            Dictionary<string, Beneficiarios> getBeneficiarios = response.ResultAs<Dictionary<string, Beneficiarios>>();
            //var get in getBeneficiarios;
            foreach( var get in getBeneficiarios)
            {
                //para encontrar un usuario o Cita
                if(get.Value.nombre == "sergio")
                {
                    label1.Text = "se encontro correctamente";
                }
                else
                {
                    label1.Text = "no se encontro el usuario";
                }
                //label1.Text= get.Value.nombre;
                Nombre.Text = get.Value.nombre;
                Apellido.Text = get.Value.apellido;
                Edad.Text = Convert.ToString(get.Value.edad);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
