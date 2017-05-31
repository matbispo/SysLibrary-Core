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
    class LivroEmprestimoService: ServiceBase<LivroEmprestimo>, ILivroEmprestimoService
    {
        private readonly ILivroEmprestimoRepository _repository;

        public LivroEmprestimoService(ILivroEmprestimoRepository repositoryLivroEmprestimo)
            : base(repositoryLivroEmprestimo)
        {
            _repository = repositoryLivroEmprestimo;
        }
    }
}
