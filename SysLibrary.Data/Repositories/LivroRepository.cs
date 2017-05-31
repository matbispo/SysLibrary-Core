using SysLibrary.Data.Context;
using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Data.Repositories
{
    public class LivroRepository : RepositoryBase<Livro>, ILivroRepository
    {
        private readonly IContextDb _db;

        public LivroRepository(IContextDb db): base(db)
        {
            _db = db;
        }

        public IEnumerable<Livro> buscarAssunto(string assunto)
        {
            return _db.Livros.ToList().Where(a => a.assunto.descAssunto == assunto);
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
