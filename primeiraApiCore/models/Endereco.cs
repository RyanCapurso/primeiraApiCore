using System.ComponentModel.DataAnnotations;

namespace primeiraApiCore.models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="O logradouro é obrigatorio")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage ="O logradouro é obrigatorio")]
        public int Numero { get; set; }
    }
}