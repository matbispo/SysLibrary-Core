using System;
using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Services;
using SysLibrary.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Services
{
    public class LivroService: ServiceBase<Livro>, ILivroService
    {
        private readonly ILivroRepository _repository;

        public LivroService(ILivroRepository repositoryLivro)
            : base(repositoryLivro)
        {
            _repository = repositoryLivro;
        }

        public IEnumerable<Livro> buscarAssunto(string assunto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> buscarAutor(string autor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> buscarTitulo(string titulo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> listarDisponiveis()
        {
            throw new NotImplementedException();
        }
    }
}
