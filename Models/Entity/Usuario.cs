using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flotex.Models.Entity
{
    [Table("Usuario")]
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; } 

        [Column("Nombre")]
        public String Nombre{ get; set; }

        [Column("ApellidoPaterno")]
        public String ApellidoPaterno { get; set; }

        [Column("ApellidoMaterno")]
        public String ApellidoMaterno{ get; set; }

        [Column("Correo")]
        public String Correo{ get; set; }

        [Column("Contrasena")]
        public String Contasena{ get; set; }
        
        [Column("Rol")]
        public String Rol{ get; set; }

    }
}