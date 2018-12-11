using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Busqueda_Binaria___Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Binario figura1 = new Binario(); //Se crea el objeto
            List<int> Lista = new List<int>(); //Declaracion de la lista

            //LISTA
            Lista.Add(2); //Declaracion de la lista 2 en 2
            Lista.Add(4);
            Lista.Add(6);
            Lista.Add(8);
            Lista.Add(10);
            Lista.Add(12);
            Lista.Add(14);
            Lista.Add(16);
            Lista.Add(18);

            int n = 4; //Se ingresa el valor que se desea consultar

            Console.WriteLine("----------------------------");
            Console.WriteLine("      BUSQUEDA BINARIA");
            Console.WriteLine("----------------------------");
            Console.WriteLine("El numero: "+ n + "...");//Desplegue
            Console.WriteLine("¿Esta en la lista? " + figura1.Binaria(n, Lista)); //Desplegue de mensaje de que si esta en la lista
            Console.ReadKey();
        }
    }
}
