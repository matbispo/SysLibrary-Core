using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public string nome { get; set; }
        public string sexo { get; set; }
        public DateTime data_nasc { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string senha { get; set; }

        public bool elegivelEmprestimo { get; set; }

        public ICollection<Emprestimo> emprestimos { get; set; }

        public Usuario()
        {
            this.emprestimos = new List<Emprestimo>();
        }

    }
}
