using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigacion.Shared.Entities
{
    public class ProyectoInvestigacion
    {
        public int Id { get; set; } 

        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Nombre {  get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha es obligatoria")]

        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "El campo fidelizacion obligatorio")]

        public string Fidelizacion { get; set; } = string.Empty;

        [Required(ErrorMessage = "El lider del proyecto es obligatorio")]

        public string LiderProyecto {  get; set; } = string.Empty;

        [Required(ErrorMessage = "La descripcion es obligatoria")]

        public string Descripcion {  get; set; } = string.Empty;

        [Required(ErrorMessage = "El nombre es obligatorio")]

        public string AreaInvestigacion {  get; set; } = string.Empty;

    }
}
