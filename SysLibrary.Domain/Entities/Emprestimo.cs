using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Entities
{
    public class Emprestimo
    {
        public int emprestimoId { get; set; }
        public DateTime dataEmprestimo { get; set; }
        public DateTime dataPrevistaDevolucao { get; set; }
        public string status { get; set; }

        public int usuarioId { get; set; }
        public Usuario usuario { get; set; }

        public ICollection<LivroEmprestimo> livroEmprestimo { get; set; }
       // public ICollection<Livro> livros { get; set; }

        public Emprestimo()
        {
            dataEmprestimo = DateTime.Now;
            dataPrevistaDevolucao = dataEmprestimo.AddDays(7);

          //  this.livros = new List<Livro>();
            this.livroEmprestimo = new List<LivroEmprestimo>();
        }

    }
}
