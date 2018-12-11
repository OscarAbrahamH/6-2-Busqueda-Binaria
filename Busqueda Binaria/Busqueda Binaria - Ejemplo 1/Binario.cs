using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Binaria___Ejemplo_1
{
    class Binario
    {
        int[] Vector = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }; //Se declara el vector
        int X1 = 0; //Inicializa en 0
        int X2 = 10; //Variable que se sumara
        int Mitad = 0;
        bool Econtrado = false;

        public void ImprimirVector()
        {
            Console.WriteLine("-------------------------------------------");
            foreach (var item in Vector) //Imprime el vector del vector declarado arriba
            {
                Console.Write("  " + item); //Impresion del vector en pantalla
            }
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------------");
        }

        public void Metodo()
        {
            int n; //declaracion de variable "n"
            Console.Write("Elemento que se desea saber la posicion: ");
            n = int.Parse(Console.ReadLine()); //Ingresar el numero del cual se quiere saber la posicion

            while (X1 <= X2 && Econtrado == false) //Comparacion
            {
                Mitad = (X1 + X2) / 2; //Mitad toma valor con la suma de la variable "X1" + "X2" y se divide entre 2
                if (Vector[Mitad] == n) //Si el numero del vector es multiplo de dos y esta en el vector es que si cumple 
                    Econtrado = true;
                if (Vector[Mitad] > n)
                    X2 = Mitad - 1;
                else
                    X1 = Mitad + 1;
            }
            if (Econtrado == false) //Arroja mensaje de que no esta en el arreglo
            {
                Console.Write("No esta en el arreglo", n);
            }
            else
            {
                Console.WriteLine(" ");
                Console.Write("--> El numero {0} se encuentra en la posicion #{1}", n, Mitad + 1); //En caso contrario si esta en el vector
            }
        }
    }
}
