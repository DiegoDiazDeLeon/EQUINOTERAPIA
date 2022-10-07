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
        public static IFirebaseClient client;
        //Se conecta a la DB a
        public static FirebaseResponse response;
        Dictionary<string, Citas> getCitas;

        DataGridViewRow renglonSelecionado;
        public InterfazCitas()
        {
            InitializeComponent();
            config();
            
            MostrarCitas();
            //SetTabPageHeaderColor(tab_CITAS,Color.Gold);
            //SetTabHeader(tab_CITAS,Color.Gold);
            
        }

        private void button_AgregarCita_Click(object sender, EventArgs e)
        {
            //Crea un form de tipo agendar cita y lo muestra
            AgendarCita agendarCita = new AgendarCita();
            agendarCita.Show();
            //MostrarCitas();
        }

        private void config()
        {
            tab_CITAS.BorderStyle = BorderStyle.None;
            IFirebaseConfig fconfig = new FirebaseConfig
            {
                AuthSecret = "czGcy6xx0Rko6k6BiQSmreMXBJJveeTdNGQXYxrv",
                BasePath = "https://equinoterapia-d4038-default-rtdb.firebaseio.com/",
            };

            client = new FirebaseClient(fconfig);
            
            try
            {
                client = new FirebaseClient(fconfig);
                response = client.Get("Citas/");
                getCitas = response.ResultAs<Dictionary<string, Citas>>();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
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
            config();
            if (getCitas != null)
            {
                dataGridView_Citas.Rows.Clear();
                //var get in getBeneficiarios;
               
                foreach (var get in getCitas)
                {
                    dataGridView_Citas.Rows.Add(
                        get.Value.CURP,
                        get.Value.id_Caballo,
                        get.Value.fechaDeCita.ToShortDateString(),
                        get.Value.Hora,
                        get.Value.Notas
                    );
                }
            }
        }

        private void InterfazCitas_Load(object sender, EventArgs e)
        {

        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            bool Existe = false;
            var buscador = Convert.ToString( textBox_buscador.Text);
            foreach (var get in getCitas)
            {
                //para encontrar un usuario o Cita
                if (get.Value.CURP == buscador)
                {
                    Existe = true;
                        string message = "Su cita es a las: " + get.Value.Hora + '\n' + "El dia: " + get.Value.fechaDeCita.ToShortDateString();
                        string title = "Beneficiario: " + get.Value.CURP;
                        MessageBox.Show(message, title);
                        break;
                }
            }
            if(Existe==false)
            {
                string message = "No Tiene Cita";
                string title = "Beneficiario: " + buscador;
                MessageBox.Show(message, title);
            }
        }
      //Renglon seleccionada
        private void dataGridView_Citas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            renglonSelecionado= dataGridView_Citas.CurrentRow;
            //MessageBox.Show(CURP);
        }

        
        private void button_eliminarCita_Click(object sender, EventArgs e)
        {
            if (renglonSelecionado != null)
            {
                string message = "¿Esta Seguro que desea eliminar cita? \n"+"Este proceso no se puede deshacer";
                string title = "Eliminar Cita";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    string curp = renglonSelecionado.Cells[0].Value.ToString();
                    client.Delete("Citas/" + curp);
                    MessageBox.Show("La cita" + renglonSelecionado.Cells[2].Value.ToString() + "ha Sido eliminado");
                }
                else
                {
                    // Do something  
                }
            }
            //(DataGridViewRow)renglonSelecionado.Cells.value
            //MostrarCitas();



        }

        private void button_AgregarCita_Click_1(object sender, EventArgs e)
        {
            //Crea un form de tipo agendar cita y lo muestra
            AgendarCita agendarCita = new AgendarCita();
            agendarCita.Show();
          //  MostrarCitas();

        }

        private void button_refrescar_Click(object sender, EventArgs e)
        {
            MostrarCitas();

        }

        public void SetTabPageHeaderColor(TabPage page, Color color)
        {
            
            TabCitas.DrawMode = TabDrawMode.OwnerDrawFixed;
            TabCitas.DrawItem += new DrawItemEventHandler(tabCitas_DrawItem);

        }

        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();
        private void SetTabHeader(TabPage page, Color color)
        {
            TabColors[page] = color;
            TabCitas.Invalidate();
        }
        private void tabCitas_DrawItem(object sender, DrawItemEventArgs e)
        {
            //e.DrawBackground();
            using (Brush br = new SolidBrush(TabColors[TabCitas.TabPages[0]]))
            {
                e.Graphics.FillRectangle(br, e.Bounds);
                SizeF sz = e.Graphics.MeasureString(TabCitas.TabPages[0].Text, e.Font);
                e.Graphics.DrawString(TabCitas.TabPages[0].Text, e.Font, Brushes.Black, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 2 + 1);

                Rectangle rect = e.Bounds;
                rect.Offset(0, 1);
                rect.Inflate(0, -1);
                e.Graphics.DrawRectangle(Pens.DarkGray, rect);
                e.DrawFocusRectangle();
            }
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            MostrarCitas();
        }
    }
}
