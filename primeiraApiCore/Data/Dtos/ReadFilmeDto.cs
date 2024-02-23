using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiraApiCore.Data.Dtos
{
    public class ReadFilmeDto
    {
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int duracao { get; set; }
    public ICollection<ReadSessaoDto> Sessoes { get; set; }
    public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
    }
}