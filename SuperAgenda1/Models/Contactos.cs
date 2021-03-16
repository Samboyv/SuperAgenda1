using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperAgenda1.Models
{
    [Table("Contactos")]
    public class Contactos
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required, MaxLength(14)]
        public string TelefonoMovil { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoTrabajo { get; set; }
        public string Empresa { get; set; }
        public string  Direccion { get; set; }
        public string  Cedula { get; set; }
        public string  Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Instagram { get; set; }
        public string Facebook{ get; set; }
        public string PaginaWeb { get; set; }
        public string PuestoTrabajo { get; set; }
        public Byte[] Foto { get; set; }


    }
}
