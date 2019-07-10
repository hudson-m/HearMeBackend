using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearMeBackend.Usuarios
{
    class DadosUsuario
    {
        public Usuario DonoDoApp { get; set; }
        public string PalavraChave { get; set; }
        public int FrequenciaDeUso { get; set; }
    }
}
