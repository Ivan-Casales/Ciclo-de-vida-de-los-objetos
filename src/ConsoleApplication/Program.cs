//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        ///--------------------------------------------------------------------------------------------------------------
        /// Parte 7
        /// Se crean 100 instancias de Train y se imprime el valor de la variable 
        ///  que contiene la cantidad de objetos creados
        /// Luego se crean 10^7 intancias de objeto, pero al reimprimir el contador de instancias, aparece con el 
        ///  valor 113, supongo que sucede porque el runtime realiza el Garbaje Collection para liberar memoria
        ///  destruyendo objetos a los cuales no se puede acceder a ellos debido a que no poseen una variable con
        ///  la dirección del Heap donde se almacenan. En pocas palabras, el método destructor se activa automaticamente.
        ///--------------------------------------------------------------------------------------------------------------
        /// Parte 8 y 9
        ///  Al realizar la comparación t1==t2 y t2 == t3, en ambos casos resulta "false", ya que t1, t2 y t3
        ///  son variables que apuntan a objetos distintos, y al ser distintas instancias, a pesar que sucede como en t1
        ///  y t3 que poseen los mismo s atributos, siguen siendo objetos distintos.
        ///--------------------------------------------------------------------------------------------------------------
        /// </summary>
        public static void Main()
        {   
            /// Parte 7
            Console.WriteLine("Parte 7 del ejercicio:");
            for (int i=0; i<100; i++)
            {
                string j = i.ToString();
                new Train(j);
            }

            Console.WriteLine($"Existen {Train.Contador} instancias de objetos.");

            for (int i=0; i<(10^7); i++)
            {
                string j = i.ToString();
                new Train(j);
            }
            Console.WriteLine($"Existen {Train.Contador} instancias de objetos.\n");

            /// Parte 8 y 9
            Console.WriteLine("Parte 8 y 9 del ejercicio:");
            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Runaway Train");
            Train t3 = new Train("Runaway Train");
            Console.WriteLine($"t1==t2 tiene el valor bool: {t1==t2}");
            Console.WriteLine($"t2==t3 tiene el valor bool: {t2==t3}");
        }

    }
}