using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

// O objetivo principal da classe TodoContext existir é servir como a ponte entre seu código C# e o banco de dados, utilizando o Entity Framework Core (EF Core). Ela encapsula toda a lógica necessária para interagir com o banco de dados, permitindo que você execute operações de CRUD (Criar, Ler, Atualizar, Deletar) nos dados representados pelas entidades do seu domínio, como TodoItem neste caso.

public class TodoContext : DbContext
{
  public TodoContext(DbContextOptions<TodoContext> options)
      : base(options)
  {
  }

  public DbSet<TodoItem> TodoItems { get; set; } = null!;
}