using SysLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Interfaces.Repositories
{
    public interface IAssuntoRepository: IRepositoryBase<Assunto>
    {
        IEnumerable<Assunto> buscarAssunto(string assunto);
    }
}
