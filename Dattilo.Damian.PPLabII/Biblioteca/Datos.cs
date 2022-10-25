using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Datos
    {
        private static List<Venta> ventas;


        
        public static List<Venta> Ventas
        {
            get { return ventas; }
            set { ventas = value; }
        }

        static Datos()
        {
            ventas = new List<Venta>();
            
        
        }
        public static void CargarProductos()
        {
            Celular c1 = new Celular(eMarca.Samsung, "sj474", eTag.Telefonia, 80000, 128, eSistemaCelular.Android, eResolucionCamara.Mp12, true);
            Televisor t2 = new Televisor(eMarca.Philips, "ph8471", eTag.Audiovisual, 100000, 42, eSistemaTV.AndroidTV, eResolucion.UHD, true);
            PC p3 = new PC(eMarca.HP, "HP142", eTag.Informatica, 120000, 500, 8, eSistemaPC.Windows, eDisco.HDD);

            Deposito.AgregarProducto(c1);
            Deposito.AgregarProducto(t2);
            Deposito.AgregarProducto(p3);

            Ventas.Add(new Venta(c1, DateTime.Now.AddMonths(-1)));
            Ventas.Add(new Venta(t2, DateTime.Now.AddMonths(-8)));
            Ventas.Add(new Venta(t2, DateTime.Now.AddMonths(-2)));
            Ventas.Add(new Venta(p3, DateTime.Now.AddDays(-20)));
           

        }

        


    }
}
