using System.ComponentModel.DataAnnotations;
namespace primeiraApiCore.Data.Dtos;

public class CreateSessaoDto
{
    [Required]
    public int FilmeId { get; set; }
    public int CinemaId { get; set; }
}