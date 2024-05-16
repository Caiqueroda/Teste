using System.ComponentModel.DataAnnotations;

namespace Avaliacao.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }

        [Required]
        [Display(Name = "Nome do Usuário")]
        public string? Nome { get; set; }
        [Required]
        public int Idade { get; set;}
        [Required]
        [Display(Name = "Endereço de Residencia")]
        public string Endereco { get; set;}
        [Required]
        public int CEP { get; set; }
        [Required]
        public string? Turma { get; set; }

    }
}
