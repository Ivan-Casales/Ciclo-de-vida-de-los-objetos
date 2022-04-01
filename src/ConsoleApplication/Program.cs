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
        /// Se crean 100 instancias de Train y se imprime el valor de la variable 
        ///  que contiene la cantidad de objetos creados
        /// </summary>
        public static void Main()
        {
            for (int i=0; i<100; i++)
            {
                new Train(i);
            }

            Console.WriteLine(Train.Contador);
        }
    }
}