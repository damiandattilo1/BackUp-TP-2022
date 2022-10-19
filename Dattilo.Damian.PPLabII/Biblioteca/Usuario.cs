using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Usuario
    {
        private string mail;
        private string password;

        public Usuario(string mail, string password)
        {
            this.mail = mail;
            this.password = password;
        }
    }
}
