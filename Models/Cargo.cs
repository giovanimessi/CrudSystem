using System.ComponentModel.DataAnnotations;

namespace CrudSystem.Models
{
    public class Cargo
    {
        [Key]
        public int CargoId { get; set; }
        public int DepartamentoId { get; set; }


        [Required(ErrorMessage = "Minimo de caractere 5")]
        [StringLength(100, ErrorMessage = "DEVE TER A O MENOR {2} caracteres")]
        [Display(Name = "Nome_Cargo")]
        public string Nome_Cargo { get; set; }

        public virtual Departamento Departamento { get; set; }


    }
   
}
