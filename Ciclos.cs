using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_definitivo
{
    public class Ciclos
    {
        public static void Ciclos_1() 
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ingreso al apartado de ciclos");
            Console.WriteLine("\n1-Imprimir todos los múltiplos de 3 que hay entre 1 y 100.");
            Console.WriteLine("\n2-Imprimir los números impares entre 0 y 100.");
            Console.WriteLine("\n3-Imprimir los números pares del 1 al 100.");
            Console.WriteLine("\n4-Escribir un programa que imprima por pantalla los cuadrados de los números del 1 al 30.");
            Console.WriteLine("\n5-Escribir un programa que sume los cuadrados de los cien primeros números naturales mostrando el resultado en pantalla.");
            Console.WriteLine("\n6-Dados dos números naturales, el primero menor que el segundo, generar y mostrar todos los números comprendidos entre ellos en secuencia ascendente. ");
            Console.WriteLine("\n7-Sumar todos los números que se digitan por teclado mientras no sea cero.");
            Console.WriteLine("----------------------------");

        }
        public static void Ci_1(int num1) 
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Los numeros multiplos de tres del 1 al 100 son: ");
            for (num1 = 3; num1 <= 100; num1 += 3)
            {
                Console.WriteLine("- " + num1);
            }
        }
        public static void ci_2(int num1) 
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Los numeros impares del 0 al 100 son: ");
            for (num1 = 1; num1 <= 100; num1 += 2)
            {
                Console.WriteLine("- " + num1);
            }
        }
        public static void ci_3(int num1) 
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Los numeros pares del 1 al 100 son: ");
            for (num1 = 2; num1 <= 100; num1 += 2)
            {
                Console.WriteLine("- " + num1);
            }
        }
        public static void ci_4(int num1) 
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Los cuadrados de los números del 1 al 30: ");
            for (num1 = 1; num1 <= 30; num1++)
            {
                Console.WriteLine("El cuadrado del numero " + num1 + " es = " + Math.Pow(num1, 2));
            }
        }
        public static void ci_5(int num1) 
        {
            int num4 = 0;
            Console.WriteLine("--------------------");
            Console.WriteLine("Los cuadrados de los numeros del 1 al 100 es: ");
            for (num1 = 1; num1 <= 100; num1++)
            {
                Console.WriteLine("El cuadrado del numero " + num1 + " es = " + Math.Pow(num1, 2));
                num4 = num4 + ((int)Math.Pow(num1, 2));
            }
            Console.WriteLine("La suma de los cuadrados es: " + num4);
        }
        public static void ci_6(int num1, int num2, int num3) 
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Ingese el primer numero natural ");
            num1 = (int)Convert.ToDouble((Console.ReadLine()));
            Console.WriteLine("Ingrese el segundo numero natural ");
            num2 = (int)Convert.ToDouble((Console.ReadLine()));
            num3 = 0;
            for (num3 = num1; num3 <= num2; num3++)
            {
                Console.WriteLine("El numero es " + num3);
            }
        }
        public static void ci_7(int num1, int num2) 
        {
            Console.WriteLine("----------------------");
            num2 = 0;
            do
            {

                num1 = (int)Convert.ToDouble((Console.ReadLine()));
                num2 = num2 + num1;
            }
            while (num1 != 0);
            Console.WriteLine("El resultado de la suma es " + num2);
        }
    }
}
