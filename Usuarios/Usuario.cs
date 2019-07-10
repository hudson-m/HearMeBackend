using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearMeBackend.Usuarios
{
    public abstract class Usuario
    {
        public string _cpf;
        public string _email;
        public string _celular;

        public string Nome { get; set; }
        public string CPF {
            get
            {
                return _cpf;
            }
            private set
            {
                // Validação de CPF
            }
        }
        public string Email {
            get
            {
                return _email;
            }
            set
            {
                //Regra de validação de e-mail.
            }
        }
        private string Senha
        {
            get
            {
                return null; //Não terá GET para senha.
            }
            set
            {
                // Lógica para senha valida (Se tiver.)
            }
        }
        public string Celular
        {
            get
            {
                return _celular;
            }
            private set
            {
                //Lógica para validação de celular.
            }
        }

        public static int TotalUsuarios
        {
            get; private set;
        }

        public Usuario(string nome, string cpf, string email, string senha, string celular)
        {
            TotalUsuarios++;

            Nome = nome;
            CPF = cpf;
            Email = email;
            Senha = senha;
            Celular = celular;
        }
    }
}
