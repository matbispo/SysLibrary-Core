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
    public class LivroEmprestimoRepository: RepositoryBase<LivroEmprestimo>, ILivroEmprestimoRepository
    {
        private readonly IContextDb _db;

        public LivroEmprestimoRepository(IContextDb db): base(db)
        {
            _db = db;
        }
    }
}
