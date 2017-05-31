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
    public class EditoraRepository : RepositoryBase<Editora>, IEditoraRepository
    {
        private readonly IContextDb _db;

        public EditoraRepository(IContextDb db): base(db)
        {
            _db = db;
        }

        public IEnumerable<Editora> buscarEditora(string editora)
        {
            return _db.Editoras.ToList().Where(e => e.descEditora  == editora);
        }
    }
}
