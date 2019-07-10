using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearMeBackend.Usuarios
{
    class RedeDeUsuario
    {
        public string _celular;
        public Usuario DonoDoApp { get; set; }
        public string Celular {
            get
            {
                return _celular;
            }
            set
            {
                //Lógica para validação de ceular.
            }
        }
    }
}
