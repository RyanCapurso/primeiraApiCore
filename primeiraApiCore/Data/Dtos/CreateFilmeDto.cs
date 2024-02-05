
using System.ComponentModel.DataAnnotations;

namespace primeiraApiCore.Data.Dtos
{
    public class CreateFilmeDto
    {
    [Required(ErrorMessage = "O titulo é obrigatorio")]
    [MaxLength(500, ErrorMessage = "O titulo não pode exceder 500 caracteres")]
    public string? Titulo { get; set; }
    [Required(ErrorMessage = "O titulo é obrigatorio")]
    [StringLength(50, ErrorMessage = "O Genero não pode exceder 50 caracteres")]
    public string? Genero { get; set; }
    [Required(ErrorMessage = "A duração é obrigatoria")]
    [Range(50, 600, ErrorMessage = "A duração deve ser de no minimo 60 até no máximo 600 segundos")]
    public int duracao { get; set; }
    }
}