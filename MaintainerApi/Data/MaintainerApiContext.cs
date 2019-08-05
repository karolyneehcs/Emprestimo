using MaintainerApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Data
{
    public class MaintainerApiContext : DbContext
    {
        public DbSet<Manutencao> Manutencoes { get; set; }
        public DbSet<MotivoManutencao> MotivoManutencoes { get; set; }
        public DbSet<Exemplar> Exemplares { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Obra> Obras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<ObraAutor> ObraAutores { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<GeneroObra> GeneroObras { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");

            modelBuilder.Entity<Manutencao>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<GeneroObra>()
                .HasKey(g => new { g.GeneroId, g.ObraId });

            modelBuilder.Entity<Exemplar>()
                .HasKey(g => new { g.ObraId });

            modelBuilder.Entity<Editora>()
                .HasKey(g => g.Id);

            modelBuilder.Entity<Emprestimo>()
                .HasKey(g => new { g.FuncionarioId, g.ObraId, g.ExemplarId });

            modelBuilder.Entity<Departamento>()
                .HasKey(g => new { g.ChefeId });

            modelBuilder.Entity<Genero>()
                .HasKey(g => g.Id);

            modelBuilder.Entity<Autor>()
                .HasKey(g => g.Id);

            modelBuilder.Entity<Reserva>()
                .HasKey(g => new { g.UsuarioId, g.ObraId });

            modelBuilder.Entity<Usuario>()
                .HasKey(g => new { g.Id, g.IndicadorId });

            modelBuilder.Entity<ObraAutor>()
                .HasKey(g => new { g.AutorId, g.ObraId }); 



            //eu gostaria de saber o pq nao está dando certo. 

        }
    }
}
