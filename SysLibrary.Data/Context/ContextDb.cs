
using Microsoft.EntityFrameworkCore;
using SysLibrary.Domain.Entities;

namespace SysLibrary.Data.Context
{
    public class ContextDb: DbContext, IContextDb
    {
        public ContextDb(DbContextOptions<ContextDb> options)
            :base(options)
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Assunto> Assuntos { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<LivroEmprestimo> LivroEmprestimo { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioSuspenso> UsuariosSuspensos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AutorLivro>()
                .HasKey(t => new { t.autorId, t.livroId});

            modelBuilder.Entity<AutorLivro>()
                .HasOne(rl => rl.Autor)
                .WithMany(t => t.autorLivro )
                .HasForeignKey(pt => pt.autorId);

            modelBuilder.Entity<AutorLivro>()
                .HasOne(rl => rl.livro)
                .WithMany(t => t.autorLivro)
                .HasForeignKey(pt => pt.livroId);


        }

        /*   private void AdminConfig(ModelBuilder model)
   {
       model.Entity<Admin>(adm =>
           {
               adm.ToTable("Admins");
               adm.HasKey(a => a.AdminId);
               adm.Property(a => a.emailAdm).IsRequired().HasMaxLength(150);
               adm.Property(a => a.login).IsRequired().HasMaxLength(50);
               adm.Property(a => a.nomeAdm).IsRequired().HasMaxLength(150);
               adm.Property(a => a.senha).IsRequired().HasMaxLength(30);
               adm.Property(a => a.registroFuncionario).IsRequired().HasMaxLength(15);
           });
   }*/
    }
}
