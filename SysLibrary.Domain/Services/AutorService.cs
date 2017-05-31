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
    public class AutorService : ServiceBase<Autor>, IAutorService
    {
    private readonly IAutorRepository _repository;

    public AutorService(IAutorRepository repositoryAutor) 
          : base(repositoryAutor)
        {
            _repository = repositoryAutor;
        }

        public IEnumerable<Autor> buscarAutor(string autor)
        {
            throw new NotImplementedException();
        }
    }
}
