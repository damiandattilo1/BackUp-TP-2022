using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Cuenta
    {
        private static List<Usuario> usuarios;
        private static Usuario usuarioActivo;
        private static Color color;

        static Cuenta()
        {
            usuarios = new List<Usuario>();
            Inicializar();
            
        }

        public static Color ColorFormulario
        {
            get { return color; }
            set { color = value; }
        }
        public static Usuario UsuarioActivo
        {
            get { return usuarioActivo; }
            set { usuarioActivo = value; }
        }

        public static List<Usuario> Usuarios
        {
            get { return usuarios; }
        }

        private static void Inicializar()
        {
            usuarios.Add(new Usuario("dueño@gmail.com", "123utn456", eTipoUsuario.Dueño));
            usuarios.Add(new Usuario("vendedor@vende.com", "444ven555", eTipoUsuario.Vendedor));
            usuarios.Add(new Usuario("contador@cuenta.com", "111cont222", eTipoUsuario.Contador));
        }

      

        public static Usuario IniciarSesion(string mail, string password)
        {
            if (mail is not null && password is not null)
            {
                foreach (Usuario item in Usuarios)
                {
                    if (mail == item.Mail && password == item.Password)
                    {
                        usuarioActivo = item;
                        return item;
                    }

                }
            }
            return new Usuario("", "", eTipoUsuario.Invalido);
        }



        



    }
}
