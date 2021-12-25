using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSystem.Models
{
    public class Cargo
    {
        [Key]
        public int CargoId { get; set; }


        [Required(ErrorMessage = "Minimo de caractere 5")]
        [StringLength(100, ErrorMessage = "DEVE TER A O MENOR {2} caracteres")]
        [Display(Name = "NomeCargo")]
        public string Nome_Cargo { get; set; }

        public int CODIGO { get; set; }
        public virtual Departamento deprtamento { get; set; }




    }
}
