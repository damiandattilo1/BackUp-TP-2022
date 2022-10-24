using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal static class Datos
    {
        internal static void CargarProductos()
        {
            Celular c1 = new Celular(eMarca.Samsung, "sj474", eTag.Telefonia, 80000, 128, eSistemaCelular.Android, eResolucionCamara.Mp12, true, 4);
            Televisor t2 = new Televisor(eMarca.Philips, "ph8471", eTag.Audiovisual, 100000, 42, eSistemaTV.AndroidTV, eResolucion.UHD, true, 2);
            PC p3 = new PC(eMarca.HP, "HP142", eTag.Informatica, 120000, 500, 8, eSistemaPC.Windows, eDisco.HDD, 5);

            Deposito.AgregarProducto(c1);
            Deposito.AgregarProducto(t2);
            Deposito.AgregarProducto(p3);


        }

    }
}
