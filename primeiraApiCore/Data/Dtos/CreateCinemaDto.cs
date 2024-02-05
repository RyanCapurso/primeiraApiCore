
using System.ComponentModel.DataAnnotations;

namespace primeiraApiCore.Data.Dtos
{
    public class CreateCinemaDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatorio")]
        public string Nome { get; set; }
    }
}