using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equinoterapia
{

    public class Beneficiarios
    {
        public string nombre { get; set; }
        public string apellido{ get; set; }
        public string curp { get; set; }
        public string dicapacidad { get; set; }
        public int edad { get; set; }

        public DateTime cumpleaños  {get; set; }
        public DateTime fechaInicio { get; set; }

    }
}
