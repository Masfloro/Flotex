using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flotex.Models.Entity
{
    public class Usuario
    {
        public int Id { get; set; }

        public String Nombre{ get; set; }

        public String ApellidoPaterno { get; set; }

        public String ApellidoMaterno{ get; set; }

        public String Correo{ get; set; }

        public String Contasena{ get; set; }

    }
}