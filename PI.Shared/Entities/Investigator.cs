using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI.Shared.Entities
{
    public class Investigator
    {
        /*Representa a los científicos y colaboradores que participan en un
        proyecto de investigación. Debe incluir detalles como nombre, afiliación institucional,
        especialización, y rol en el proyecto*/

        public int Id { get; set; }

        [Display(Name = "Investigador")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null;

        public string Membership { get; set; } = null;
        public string Specialization { get; set;} = null;
        public string Role { get; set; } = null;


    }
}
