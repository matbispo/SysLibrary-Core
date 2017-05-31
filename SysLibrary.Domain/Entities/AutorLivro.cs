using System;
using System.Collections.Generic;
using System.Text;

namespace SysLibrary.Domain.Entities
{
    public class AutorLivro
    {
        public int autorId { get; set; }
        public int livroId { get; set; }
        public Livro livro { get; set; }
        public Autor Autor { get; set; }
    }
}
