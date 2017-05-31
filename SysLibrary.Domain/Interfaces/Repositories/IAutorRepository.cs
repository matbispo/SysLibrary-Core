using SysLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Interfaces.Repositories
{
    public interface IAutorRepository : IRepositoryBase<Autor>
    {
        IEnumerable<Autor> buscarAutor(string autor);
    }
}
