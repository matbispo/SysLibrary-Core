using System;
using System.Collections.Generic;
using System.Text;

namespace SysLibrary.AppService.DTOs
{
    public class AdminDTO
    {
        public int AdminId { get; set; }
        public string nomeAdm { get; set; }
        public string emailAdm { get; set; }
        public string registroFuncionario { get; set; }
    }
}
