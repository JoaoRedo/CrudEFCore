using System.ComponentModel.DataAnnotations;

namespace CrudEF.Models
{
    public class Funcionario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "O cargo é obrigatório")]
        [StringLength(50, ErrorMessage = "O cargo deve ter no máximo 50 caracteres")]
        public string Cargo { get; set; } = string.Empty;

        [Required(ErrorMessage = "A data de contratação é obrigatória")]
        [Display(Name = "Data de Contratação")]
        [DataType(DataType.Date)]
        public DateTime DataContratacao { get; set; } = DateTime.UtcNow;

        [Required(ErrorMessage = "O salário é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "O salário deve ser maior que zero")]
        public decimal Salario { get; set; }
    }
} 