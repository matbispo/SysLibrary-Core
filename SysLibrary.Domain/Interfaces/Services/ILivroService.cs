using SysLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Interfaces.Services
{
    public interface ILivroService : IServiceBase<Livro>
    {
        IEnumerable<Livro> buscarTitulo(string titulo);

        IEnumerable<Livro> buscarAssunto(string assunto);

        IEnumerable<Livro> buscarAutor(string autor);

        IEnumerable<Livro> listarDisponiveis();
    }
}
