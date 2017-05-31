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
    public class EmprestimoService : ServiceBase<Emprestimo>, IEmprestimoService
    {
        private readonly IEmprestimoRepository _repository;

        public EmprestimoService(IEmprestimoRepository repositoryEmprestimo)
            :base(repositoryEmprestimo)
        {
            _repository = repositoryEmprestimo;
        }
    }
}
