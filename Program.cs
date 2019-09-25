using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_Suma_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui se instancia la clase operacion
            Operacion OP = new Operacion();

            OP.Suma();

            //Declaracion de variables 
            var Rest = OP.Suma(2, 3);
            var Rest2 = OP.Suma(20);
            var Rest3 = OP.Suma();

            //Mandamos imprimir resultado

            Console.WriteLine("El resultado 1 es igual a:" + Rest);
            Console.WriteLine("El resultado 2 es igual a:" + Rest2);
            Console.WriteLine("El resultado 3 es igual a:" + Rest3);

            Console.ReadKey();
            //Llamamos a la clase datos y la instanciamos
            Datos d = new Datos();
            d.Obtener_Datos();

        }
    }
}
