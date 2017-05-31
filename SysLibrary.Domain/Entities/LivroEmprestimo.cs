using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Entities
{
    public class LivroEmprestimo
    {
        public int livroEmprestimoId { get; set; }
        public bool devolvido { get; set; }
        public DateTime? dataDevolucao { get; set; }

        public int livroId { get; set; }
        public int emprestimoId { get; set; }

        public Livro livro { get; set; }
        public Emprestimo emprestimo { get; set; }

        public LivroEmprestimo()
        {
            devolvido = false;
            dataDevolucao = null;
        }

    }
}
