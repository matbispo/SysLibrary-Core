using Microsoft.EntityFrameworkCore;
using SysLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace SysLibrary.Data.Context
{
    public interface IContextDb
    {

         DbSet<Admin> Admins { get; set; }
         DbSet<Assunto> Assuntos { get; set; }
         DbSet<Autor> Autores { get; set; }
         DbSet<Editora> Editoras { get; set; }
         DbSet<Emprestimo> Emprestimos { get; set; }
         DbSet<LivroEmprestimo> LivroEmprestimo { get; set; }
         DbSet<Livro> Livros { get; set; }
         DbSet<Usuario> Usuarios { get; set; }
         DbSet<UsuarioSuspenso> UsuariosSuspensos { get; set; }

         DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();

        EntityEntry Entry(object entity);

        EntityEntry<TEntity> Entry<TEntity>( TEntity entity) where TEntity : class;

    }
}
