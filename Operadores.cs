using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_definitivo
{
    public class Operadores
    {public static void Operadores_1 ()
        {
      

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Elejiste el apartado de operadores");
            Console.WriteLine("\n1- Suma");
            Console.WriteLine("\n2- Area del triangulo");
            Console.WriteLine("\n3- Numero elevado al cuadrado");
            Console.WriteLine("\n4- area de un cilindro y volumen");
            Console.WriteLine("\n5- Algoritmo que pida el lado de un cuadrado y muestre el valor del área y delperímetro.");
            Console.WriteLine("\n6- Escribir un algoritmo que convierta de euros a dólares.");
            Console.WriteLine("\n7- Realizar un algoritmo que lea el radio de una circunferencia y escriba la longitud de la misma y el área (pi * r) ^ 2 del círculo inscrito.");
            Console.WriteLine("\n8- Calcular el promedio de tres (3) números ingresados por teclado.");
            Console.WriteLine("Elija la operacion que desea realizar");
            Console.WriteLine("-----------------------------------------------------");



        }
        public static void op_1(int num1, int num2)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ingrese un numero entero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero entero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado de la operacion es");
            Console.WriteLine(num1 + num2);
            Console.WriteLine("---------------------------");
        }
        public static void op_2(int num1,int num2)
        {
            Console.WriteLine("Ingrese un numero entero");
            num1 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Ingrse un numero entero");
            num2 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("El resultado de la operacion es:");
            Console.WriteLine((num1 * num2) / 2);
        }
    
        public static void op_3(int num1)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Ingrese un numero entero");
            num1 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("El resultado de la operacion es");
            Console.WriteLine(Math.Pow(num1, 2));
        }
    
        public static void op_4(int num1, int num2)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Ingrese un numero entero");
            num1 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Ingrese un numero entero");
            num2 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("El resultado de la operacion es");
            Console.WriteLine(2 * Math.PI * num1 * num2);
            Console.WriteLine("----------------------");
        }
      
        public static void op_5(int num1)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Ingrese un numero entero");
            num1 = (int)Double.Parse((Console.ReadLine()));
            Console.WriteLine("-----------------------");

            Console.WriteLine("El area de un cuadrado es");
            Console.WriteLine(num1 * num1);
            Console.WriteLine("El perimetro de un cuadrado es");
            Console.WriteLine(num1 + num1 + num1 + num1);
        }

        public static void op_6(int num1)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Ingrese el valor en Euros");
            num1 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("El valor de Euros en dolares es:");
            Console.WriteLine(num1 * 1.06);
        }

        public static void op_7(int num1)
        {
            double Rad;
            Console.WriteLine("------------------------");
            Console.WriteLine("Ingrese el Diametro de la circunferencia");
            num1 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("El valor del radio es:");
            Console.WriteLine(Rad = num1 / 2);
            Console.WriteLine("El valor del area de la circunferencia es");
            Console.WriteLine((Math.PI * (Rad * Rad)));
            Console.WriteLine("La longitud de la circunferencia es:");
            Console.WriteLine(Math.PI * 2 * Rad);
            Console.WriteLine("--------------------------");
        }
      
        public static void op_8(int num1, int num2, int num3)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Ingrese el tercer numero");
            num3 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("El promedio de los tres numero es:");
            Console.WriteLine((num1 + num2 + num3) / 3);
            Console.WriteLine("---------------------------");
        }
    }
}
