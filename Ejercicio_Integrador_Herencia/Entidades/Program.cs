using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero miLavadero = new Lavadero(100, 150, 50);
            Vehiculo v1 = new Vehiculo("TER345", 3, EMarcas.Zanella);

            Auto a1 = new Auto("ABC123", 4, EMarcas.Fiat, 5);
            Auto a3 = new Auto("ERT563", 4, EMarcas.Iveco, 7);
            Moto m1 = new Moto("CDE456", 2, EMarcas.Honda, 1, 6f);
            Camion c1 = new Camion("FGH789", 4, EMarcas.Frord, 2, 4f);
            
            miLavadero += a1;
            miLavadero += a1;
            miLavadero += a3;
            miLavadero += m1;
            miLavadero += c1;


            Console.WriteLine(miLavadero.GetLavadero);
            Console.WriteLine("Total autos: {0}", miLavadero.MostrarTotalFacturado());

            miLavadero -= a1;
            Console.WriteLine("*******************CAMBIOS********************");
            Console.WriteLine(miLavadero.GetLavadero);
            Console.WriteLine("Total autos: {0}", miLavadero.MostrarTotalFacturado());

            Console.ReadKey();
        }
    }
}
