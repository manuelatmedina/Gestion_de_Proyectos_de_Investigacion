using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI.Shared.Entities
{
    public class Project
    {
        /*Esta entidad representa un proyecto de investigación
        específico. Debe tener atributos como nombre del proyecto, fecha de inicio y
        finalización, líder del proyecto, descripción y área de investigación.*/

        public int Id { get; set; }

        [Display (Name="Proyecto")]
        [Required(ErrorMessage ="El campo {0} es obligatorio.")]
        public string Name { get; set; } = null;

        [Display(Name = "Fecha de Inicio")]
        [Required(ErrorMessage = "El campo {1} es obligatorio.")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Fecha Finalizacion")]
        [Required(ErrorMessage = "El campo {2} es obligatorio.")]
        public DateTime FinishDate { get; set; }
        public string Owner { get; set; } = null;
        public string Description { get; set; } = null;
        public string Department { get; set; } = null;


    }
}
