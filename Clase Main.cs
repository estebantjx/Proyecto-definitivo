using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_definitivo
{
    public class Clase_Main
    
    {
        public static void Main()
        {
            do
            {
                try
                {
                    double menu_1;
                    Clase_menu.menu();
                    menu_1 = Convert.ToDouble(Console.ReadLine());
                    switch (menu_1)
                    {
                        case 1:
                            Class_Operadores.Op_menu();
                            double menu_2 = Convert.ToDouble(Console.ReadLine());
                            switch (menu_2)
                            {
                                case 1:
                                    Class_Operadores.Op_1(1, 2);
                                    break;

                                case 2:
                                    Class_Operadores.Op_2(1, 2);
                                    break;

                                case 3:
                                    Class_Operadores.Op_3(1);
                                    break;

                                case 4:
                                    Class_Operadores.Op_4(1);
                                    break;

                                case 5:
                                    Class_Operadores.Op_5(1);
                                    break;

                                case 6:
                                    Class_Operadores.Op_6(1, 2);
                                    break;

                                case 7:
                                    Class_Operadores.Op_7(1);
                                    break;

                                case 8:
                                    Class_Operadores.Op_8(1, 2, 3);
                                    break;

                                case 9:
                                    Class_Operadores.Op_def();
                                    break;
                            }
                            break;

                        case 2:
                            Class_Condicionales.Op_menu();
                            double menu_3 = Convert.ToDouble(Console.ReadLine());
                            switch (menu_3)
                            {
                                case 1:
                                    Class_Condicionales.Op_1(1);
                                    break;

                                case 2:
                                    Class_Condicionales.Op_2(1, 2);
                                    break;

                                case 3:
                                    Class_Condicionales.Op_3(1, 2, 3);
                                    break;

                                case 4:
                                    Class_Condicionales.Op_4(1, 2);
                                    break;

                                case 5:
                                    Class_Condicionales.Op_5(1, 2);
                                    break;

                                case 6:
                                    Class_Condicionales.Op_6(1, 2);
                                    break;

                                case 7:
                                    Class_Condicionales.Op_7(1);
                                    break;

                                case 8:
                                    Class_Condicionales.Op_def();
                                    break;

                            }
                            break;

                        case 3:
                            Class_Condicionales.Op_menu();
                            double menu_4 = Convert.ToDouble(Console.ReadLine());
                            switch (menu_4)
                            {
                                case 1:
                                    Class_Ciclos.Op_1(1);
                                    break;

                                case 2:
                                    Class_Ciclos.Op_2(1);
                                    break;

                                case 3:
                                    Class_Ciclos.Op_3(1);
                                    break;

                                case 4:
                                    Class_Ciclos.Op_4(1);
                                    break;

                                case 5:
                                    Class_Ciclos.Op_5(1, 2, 3);
                                    break;

                                case 6:
                                    Class_Ciclos.Op_6(1, 2, 3);
                                    break;

                                case 7:
                                    Class_Ciclos.Op_7(1, 2);
                                    break;

                                case 8:
                                    Class_Ciclos.Op_def();
                                    break;
                            }
                            break;

                        case 9:
                            break;

                        default:
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("El termino ingresado no es valido");
                }
                
                Console.WriteLine("Presione ENTER para volver");
                Console.ReadKey();
                Console.Clear();
            } while (true);

        }

    }
}
