using System;
using System.Collections.Generic;

namespace PracticaA01
{
    class Program
    {
        delegate void Calcular();
        delegate void Imprime(double i);

        static void Main(string[] args)
        {
            List<int> resultado = new List<int>();
            int[] arreglo;
            int objLenght;
            Console.WriteLine("Digite la dimension del arreglo");
            objLenght = int.Parse(Console.ReadLine());

            arreglo = new int[objLenght];

            for (int i = 0; i < objLenght; i++)
            {
                Console.Write("Ingrese el valor de la celda {0} :", i);
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            Numbers nuevoArreglo = new Numbers(arreglo);

            Calcular calculo = new Calcular(nuevoArreglo.GetMaxValue);
            Imprime imprimir = new Imprime(nuevoArreglo.PrintResults);
            calculo();
            Console.WriteLine($"El valor maximo es:");
            imprimir(nuevoArreglo.vResult);
            Console.WriteLine("**********************************************************");
            calculo = new Calcular(nuevoArreglo.GetMinValue);
            calculo();
            Console.WriteLine($"El valor minimo es:");
            imprimir(nuevoArreglo.vResult);
            Console.WriteLine("**********************************************************");
            calculo = new Calcular(nuevoArreglo.GetAverage);
            calculo();
            Console.WriteLine($"El valor promedio es:");
            imprimir(nuevoArreglo.vResult);
            Console.WriteLine("**********************************************************");
            calculo = new Calcular(nuevoArreglo.GetARMS);
            calculo();
            Console.WriteLine($"El valor ARMS es:");
            imprimir(nuevoArreglo.vResult);
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Los pares son:");
            Predicate<int> numEvaluation = new Predicate<int>(nuevoArreglo.EvenNumbers);
            resultado = nuevoArreglo.numbers.FindAll(numEvaluation);
            

            foreach (int number in resultado)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("**********************************************************");
            Console.WriteLine("Los impares son:");
            numEvaluation = new Predicate<int>(nuevoArreglo.OddNumbers);
            resultado = nuevoArreglo.numbers.FindAll(numEvaluation);

            foreach (int number in resultado)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("**********************************************************");
            Console.WriteLine("Los multiplos de 3 son:");
            numEvaluation = new Predicate<int>(nuevoArreglo.IsMultipleOfThree);
            resultado = nuevoArreglo.numbers.FindAll(numEvaluation);

            foreach (int number in resultado)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("**********************************************************");

            Func<int[], List<int>> SortDescending = nuevoArreglo.OrderDescending;

            resultado = SortDescending(arreglo);

            Console.WriteLine("La lista ordenada descendente es:");

            foreach (int number in resultado)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("**********************************************************");

            Console.WriteLine("La lista ordenada ascendente es:");

            Action<int[]> SortAscending = nuevoArreglo.OrderAscending;

            SortAscending(arreglo);



        }
    }


    
}


