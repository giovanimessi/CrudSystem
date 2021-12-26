using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSystem.Models
{
    public class Departamento
    {
        [Key]
        public int CODIGO { get; set; }

        [Required(ErrorMessage = "Minimo de caractere 5")]
        [StringLength(100, ErrorMessage = "DEVE TER A O MENOR {2} caracteres")]
        [Display(Name = "NOME")]
        public string NOME { get; set; }

        public virtual ICollection<Cargo> cargos { get; set; }


    }


}
