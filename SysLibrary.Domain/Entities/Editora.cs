using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Entities
{
    public class Editora
    {
        public int editoraId { get; set; }
        public string descEditora { get; set; }
        public ICollection<Livro> livros { get; set; }

        public Editora()
        {
            this.livros = new List<Livro>();
        }

    }
}
