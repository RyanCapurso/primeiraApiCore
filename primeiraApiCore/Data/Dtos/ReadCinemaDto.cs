using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace primeiraApiCore.Data.Dtos
{
    public class ReadCinemaDto
    {
        public int Id { get; set;}
        [Required(ErrorMessage = "O campo de nome é obrigatorio")]
        public string Nome { get; set; }
        public ReadEnderecoDto ReadEnderecoDto { get; set; }
        public ICollection<ReadSessaoDto> Sessoes { get; set; }
        public DateTime DataDeAcesso { get; set; } = DateTime.Now;
    }
}