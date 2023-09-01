using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigacion.Shared.Entities
{
    public class Investigadore
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "el nombre es necesario")]

        public string NombreInvestiigadores { get; set; } = string.Empty;

        [Required(ErrorMessage = "la afiliacion es necesaria")]

        public string AfiliacionInstitucional { get; set; } = string.Empty;

        [Required(ErrorMessage = "la especializacion es necesaria")]

        public string Especializacion { get; set; } = string.Empty;

        [Required(ErrorMessage = "El Rol es necesario")]

        public string Rol { get; set; } = string.Empty;

    }
}
