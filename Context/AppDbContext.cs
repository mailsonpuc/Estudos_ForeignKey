using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //models
        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Professor> Professor { get; set; }


       //configura a chave estrangeira 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>()
                .HasOne(a => a.Professor)
                .WithMany(p => p.Alunos)
                .HasForeignKey(a => a.ProfessorId);
        }



    }


}