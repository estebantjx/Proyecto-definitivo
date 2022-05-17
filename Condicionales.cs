using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_definitivo
{
    public class Condicionales
   {
        public static void Condicionales_1() 
      {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Selecciono el apartado de condicionales");
            Console.WriteLine("\n1- Escribir un algoritmo para saber si el número ingresado por teclado es positivo o negativo.");
            Console.WriteLine("\n2- Escribir un algoritmo que reciba dos números por teclado y diga cuál es el mayor y cuál el menor.");
            Console.WriteLine("\n3- Escriba un programa que lea tres números enteros positivos y que calcule e imprima enpantalla el menor y el mayor de ellos.");
            Console.WriteLine("\n4- Dados dos números A y B, sumarlos si A es menor que B o sino restarlos.");
            Console.WriteLine("\n5- Encontrar el cociente entre A y B.");
            Console.WriteLine("\n6- Dados dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos.");
            Console.WriteLine("\n7- Escribir un algoritmo que determine si un año es bisiesto o no.");
            Console.WriteLine("---------------------------------------");
      }
        public static void co_1(int num1) 
        {
            Console.WriteLine("Ingrese un numero");
            num1 = Convert.ToInt32((Console.ReadLine()));
            if (num1 > 0)
            {

                Console.WriteLine("El numero " + num1 + " es positivo");
            }
            else
            {
                Console.WriteLine("El numero " + num1 + " es negativo");

            }
        }
        public static void co_2(int num1, int num2) 
        {
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Ingrese el sugundo numero");
            num2 = Convert.ToInt32((Console.ReadLine()));
            if (num1 > num2)
            {
                Console.WriteLine("El numero " + num1 + " es mayor que " + num2);

            }
            else
            {
                Console.WriteLine("El numero " + num1 + " es menor que " + num2);

            }
        }
        public static void co_3(int num1, int num2, int num3) 
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Ingrese el tercer numero");
            num3 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("----------------------------");
            if (num1 > num2)
            {
                Console.WriteLine("El numero mayo es: " + num1);
            }
            else if (num2 > num3)
            {
                Console.WriteLine("El numero mayor es: " + num2);
            }
            else
            {
                Console.WriteLine("El numero mayor es: " + num3);
            }
            if (num1 < num2)
            {
                Console.WriteLine("El numero menor es: " + num1);
            }
            else if (num2 < num3)
            {
                Console.WriteLine("El numero menor es: " + num2);

            }
            else
            {
                Console.WriteLine("El numero menor es: " + num3);
            }


        }
        public static void co_4(int num1, int num2) 
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Ingrese el primero numero: ");
            num1 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("----------------------------");
            if (num1 < num2)
            {
                Console.WriteLine("El resulato de la suma de los numeros es: " + (num1 + num2));
            }
            else
            {
                Console.WriteLine("La resultado de la resta de los numeros es: " + (num1 - num2));
            }
        }

        public static void co_5(int num1, int num2) 
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Ingrese el numerador: ");
            num1 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Ingrese el denominador: ");
            num2 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("-------------------------");

            if (num1 == 0)
            {
                Console.WriteLine("La division es igual a 0 ");
            }
            else if (num2 == 0)
            {
                Console.WriteLine("La division no es posible ");
            }
            else
            {
                Console.WriteLine("El resultado de la division es: " + (num1 / num2));
            }
        }
        public static void co_6(int num1, int num2) 
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Ingrese el numerador");
            num1 = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Ingrese el segundo numero");
            num2 = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("--------------------------");
            if (num1 < 0)
            {
                Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
            }
            else if (num2 < 0)
            {
                Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
            }
            else
            {
                Console.WriteLine("El resultado de la multiplicacion es: " + (num1 * num2));
            }
        }
        public static void co_7(int num1) 
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Ingrese el año");
            num1 = (int)Convert.ToDouble((Console.ReadLine()));
            Console.WriteLine("-----------------------");

            if (num1 % 4 == 0 && (num1) % 100 != 0 || (num1) % 400 == 0)
            {
                Console.WriteLine("Es bisiesto {0} \n", num1);
            }
            else
            {
                Console.WriteLine("No es bisiesto {0} \n ", num1);
            }
        }

       

    }
}
