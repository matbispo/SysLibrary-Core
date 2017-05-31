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
    public class AssuntoService : ServiceBase<Assunto>, IAssuntoService
    {
        private readonly IAssuntoRepository _repository;

        public AssuntoService(IAssuntoRepository repositoryAssunto) 
            : base(repositoryAssunto)
        {
            _repository = repositoryAssunto;
        }

        public IEnumerable<Assunto> buscarAssunto(string assunto)
        {
            throw new NotImplementedException();
        }
    }
}
