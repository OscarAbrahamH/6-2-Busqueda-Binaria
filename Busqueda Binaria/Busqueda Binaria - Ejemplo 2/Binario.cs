using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Binaria___Ejemplo2
{
    class Binario
    {
        public bool Binaria(int Elemento, List<int> Lista) //Se crea un bool
        {
            int Numeros = Lista.Count; //Numeros toma entrada de la lista declarada
            int Mitad; //Operacion donde se saca la mitad
            int X1=0;
            int X2 = Numeros - 1;

            while (X1 <= X2)
            {
                Mitad = ((X2 - X1) / 2 + X1); //Se realiza la operacion
                if (Lista[Mitad] == Elemento) //Si Esta en la lista sera verdadero
                {
                    return true;
                }
                else
                {
                    if (Elemento < Lista[Mitad]) //Si no esta no se realizara arrojara falso
                    {
                        X2 = Mitad - 1;
                    }
                    else
                    {
                        X1 = Mitad + 1;
                    }
                }
            } 
            return false;
        }

    }
}

