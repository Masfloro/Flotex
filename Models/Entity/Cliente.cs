using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Flotex.Models.Entity
{

    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Column("NumeroDocumento")]
        public int NumeroDocumento { get; set; }

        [Column("Nombre")]
        public String Nombre { get; set; }

        [Column("ApellidoPaterno")]
        public String ApellidoPaterno { get; set; }

        [Column("ApellidoMaterno")]
        public String ApellidoMaterno { get; set; }

        [Column("Telefono")]
        public string Telefono { get; set; }

        [EmailAddress]
        [Column("Email")]
        public string Email { get; set; }

        [Column("Direccion")]
        public String Direccion { get; set; }

        [Column("Genero")]
        public String Genero { get; set; }

        [Column("FechaNacimiento")]
        public String FechaNacimiento { get; set; }





    }
}