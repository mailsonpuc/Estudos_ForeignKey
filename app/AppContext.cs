using Microsoft.EntityFrameworkCore;

public class AppContext : DbContext
{
    
    public DbSet<Professor>? Professores { get; set; }
    public DbSet<Aluno>? Alunos { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=app1.db");
    }
}


