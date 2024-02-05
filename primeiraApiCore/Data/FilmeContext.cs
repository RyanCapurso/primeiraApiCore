
using Microsoft.EntityFrameworkCore;
using primeiraApiCore.models;
using primeiraApiCore.Models;

namespace primeiraApiCore.Data;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> opts)
        : base(opts)
    {

    }

    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Cinema> Cinemas { get; set;}
    public DbSet<Endereco> Enderecos { get; set;}
}