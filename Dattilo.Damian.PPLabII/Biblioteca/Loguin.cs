using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Loguin
    {
        private static string usuDuenio;
        private static string passDuenio;
        
        private static string passVendedor;
        private static string usuVendedor;

        private static string passContador;
        private static string usuContador;

        public static string UsuDuenio
        {
            get { return usuDuenio; }
        }

        public static string PassDuenio
        {
            get { return passDuenio; }
        }

        public static string UsuVendedor
        {
            get { return usuVendedor; }
        }

        public static string PassVendedor
        {
            get { return passVendedor; }
        }

        public static string UsuContador
        {
            get { return usuContador; }
        }

        public static string PassContador
        {
            get { return passContador; }
        }



        static Loguin()
        {
            usuDuenio = "dueño@gmail.com";
            passDuenio = "123utn456";

            usuVendedor = "vendedor@vende.com";
            passVendedor = "444ven555";

            usuContador = "contador@cuenta.com";
            passContador = "111cont222";
        }

        /// <summary>
        /// Devuelve un valor entero que dice si usuario y contrasenia son correctos y de que tipo de usuario se trata
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contrasenia"></param>
        /// <returns></returns> 0 si es duenio, 1 si es vendedor, 2 si es contador o -1 si usuario y/o contrasenia son invalidos
        public static int Loguearse(string usuario, string contrasenia)
        {

            if(string.Equals(usuDuenio, usuario) && string.Equals(passDuenio, contrasenia))
            {
                return 0;
            }
            else if (string.Equals(usuVendedor, usuario) && string.Equals(passVendedor, contrasenia))
            {
                return 1;
            }
            else if (string.Equals(usuContador, usuario) && string.Equals(passContador, contrasenia))
            {
                return 2;
            }

            return -1;
        }

    }
}
