using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace primeiraApiCore.Data.Dtos
{
    public class ReadCinemaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatorio")]
        public string Nome { get; set; }
        public DateTime DataDeAcesso { get; set; } = DateTime.Now;
    }
}