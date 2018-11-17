using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using SysLibrary.AppService.DTOs;
using SysLibrary.Domain.Entities;

namespace SysLibrary.AppService.MapperConfig
{
    public class AutoMapperConfig : Profile
    {
          public AutoMapperConfig()
          {
            // Entity to DTO

            CreateMap<Admin, AdminDTO>();
            CreateMap<Assunto, AssuntoDTO>();
            CreateMap<Autor, AutorDTO>();
            CreateMap<AutorLivro, AutorLivroDTO>();
            CreateMap<Editora, EditoraDTO>();
            CreateMap<Emprestimo, EmprestimoDTO>();
            CreateMap<Livro, Livro>();
            CreateMap<LivroEmprestimo, LivroEmprestimoDTO>();
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<UsuarioSuspenso, UsuarioSuspensoDTO>();

            // DTO to Entity

            CreateMap<AdminDTO, Admin>();
            CreateMap<AssuntoDTO, Assunto>();
            CreateMap<AutorDTO, Autor>();
            CreateMap<AutorLivroDTO, AutorLivro>();
            CreateMap<EditoraDTO, Editora>();
            CreateMap<EmprestimoDTO, Emprestimo>();
            CreateMap<LivroDTO, Livro>();
            CreateMap<LivroEmprestimoDTO, LivroEmprestimo>();
            CreateMap<UsuarioDTO, Usuario>();
            CreateMap<UsuarioSuspensoDTO, UsuarioSuspenso>();

            // talvez isso possa ser dividido em duas classes
        }
    }
}
