using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_Suma_
{
    class Operacion
    {
        //Aqui se agregan 3 metodos para despues llamar a la sobre carga
        public double Suma(double a, double b)
        {
            return a + b;
        }

        public double Suma(double a)
        {
            return a;
        }

        public double Suma()
        {
            return 0;
        }
    }
}
