using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Busqueda_Binaria___Ejemplo_1;

namespace Busqueda_Binaria___Ejemplo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("           BUSQUEDA BINARIA");
            Binario figura1 = new Binario(); //Declaracion de la figura
            figura1.ImprimirVector(); //Proceso que imprime el vector
            Console.WriteLine(" ");
            figura1.Metodo(); //Ejecucion del metodo 
            Console.ReadKey();
        }
    }
}
