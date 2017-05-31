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
    public class EditoraService: ServiceBase<Editora>, IEditoraService
    {
        private readonly IEditoraRepository _repository;

        public EditoraService(IEditoraRepository repositoryEditora): 
            base(repositoryEditora)
        {
            _repository = repositoryEditora;
        }

        public IEnumerable<Editora> buscarEditora(string editora)
        {
            throw new NotImplementedException();
        }
    }
}
