using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Entities
{
    public class Autor
    {
        public int autorId { get; set; }
        public string nomeAutor { get; set; }

       // public IEnumerable<Livro> livros { get; set; }

        public IEnumerable<AutorLivro> autorLivro { get; set; }

        public Autor()
        {
           // this.livros = new List<Livro>();
        }
    }
}
