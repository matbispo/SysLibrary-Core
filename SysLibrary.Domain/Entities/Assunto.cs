using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysLibrary.Domain.Entities
{
    public class Assunto
    {
        public int AssuntoId { get; set; }
        public string descAssunto { get; set; }
        public ICollection<Livro> livros { get; set; }

        public Assunto()
        {
            this.livros = new List<Livro>();
        }
    }
}
