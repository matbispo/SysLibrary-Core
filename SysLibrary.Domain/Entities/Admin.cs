using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Entities
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string nomeAdm { get; set; }
        public string emailAdm { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string registroFuncionario { get; set; }
    }
}
