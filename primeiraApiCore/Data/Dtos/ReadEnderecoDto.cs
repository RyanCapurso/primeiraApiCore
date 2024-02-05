using System.ComponentModel.DataAnnotations;

namespace primeiraApiCore.Data.Dtos
{
    public class ReadEnderecoDto
    {
 
        [Required(ErrorMessage ="O logradouro é obrigatorio")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage ="O logradouro é obrigatorio")]
        public int Numero { get; set; }
    }
}