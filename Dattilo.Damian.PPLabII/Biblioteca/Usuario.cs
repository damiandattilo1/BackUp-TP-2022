using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario
    {
        private string mail;
        private string password;
        private eTipoUsuario tipoUsuario;

        public string Mail
        {
            get { return mail; }
        }

        public string Password
        {
            get { return password; }
        }

        public eTipoUsuario TipoUsuario
        {
            get { return tipoUsuario; }
        }

        public Usuario(string mail, string password, eTipoUsuario usuario)
        {
            this.mail = mail;
            this.password = password;
            this.tipoUsuario = usuario;
        }

        public static bool operator ==(Usuario a, Usuario b)
        {
            return a.tipoUsuario == b.tipoUsuario && a.password == b.password;
        }

        public static bool operator !=(Usuario a, Usuario b)
        {
            return !(a == b);
        }
    }
}
