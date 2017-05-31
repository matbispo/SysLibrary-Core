using System;
using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysLibrary.Data.Context;

namespace SysLibrary.Data.Repositories
{
    public class AssuntoRepository : RepositoryBase<Assunto>, IAssuntoRepository
    {

        private readonly IContextDb _db;

        public AssuntoRepository(IContextDb db): base(db)
        {
            _db = db;
        }

        public IEnumerable<Assunto> buscarAssunto(string assunto)
        {
            return _db.Assuntos.ToList().Where(a=> a.descAssunto == assunto);
        }
    }
}
