using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Users_Profile
{
    class Usuario
    {
        private string user, email, password;
        private int codigo;
        public Usuario() { }
        public Usuario(string user, string email, string password, int codigo) {
            this.user = user;
            this.email = email;
            this.password = password;
            this.codigo = codigo;
        }
        public string User { get => user;
            set
            {
                user = value;
                if (user == "") throw new Exception("Debe ingresar un usuario");
            }
        }
        public string Email { get => email;
            set 
            {
                email = value;
                Regex regEmail = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))", RegexOptions.Compiled);
                if (!regEmail.IsMatch(email)) throw new Exception("Debe ingresar un correo");
            }
        }
        public string Password { get => password; set => password = value; }
        public int Codigo { get => codigo; set => codigo = value; }
    }
}
