using System;
using Biblioteca;


namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool agrega = false;
            Lapiz l1 = new Lapiz("Faber Castell", 88, eColor.Verde, eTrazo.HB);
            Lapiz l2 = new Lapiz("Pelikan", 88, eColor.Verde, eTrazo.H);
            Sacapunta s1 = new Sacapunta("Unitech", 2050, true, 2);
            Goma g1 = new Goma("Boligoma", 700, true, 3);
            Goma g2 = new Goma("a", 45, false, 5);
            Goma g3 = new Goma("a", 45, true, 5);
            Sacapunta s2 = new Sacapunta("Pelikan", 2050, false, 2);

            Cartuchera < Util > cartuchera= new Cartuchera<Util>(2);

            try
            {
                cartuchera += g1;
                cartuchera = cartuchera + g2;
                
                cartuchera += g3;


            }
            catch(CartucheraLlenaException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                foreach (Util item in cartuchera.Lista)
                {
                    Console.WriteLine(item);
                }
            }

           /* GomaDAO gomaDAO = new GomaDAO();
            LapizDAO lapizDAO = new LapizDAO();

            SacapuntasDAO sacapuntasDAO = new SacapuntasDAO();

            gomaDAO.Insertar(g1);
            gomaDAO.Insertar(g2);

            sacapuntasDAO.Insertar(s1);
            sacapuntasDAO.Insertar(s2);

            lapizDAO.Insertar(l1);
            lapizDAO.Insertar(l2);
            
            
            foreach (Lapiz item in lapizDAO.Leer())
            {
                Console.WriteLine(item);
            }*/

        }
    }

    public static class Prueba
    {
            public static void EventoAccionado(object cartuchera, PrecioEventArgs a)
            {
                Console.WriteLine("\nSe acciono el evento\n");
            }

    }
}
