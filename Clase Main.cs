using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_definitivo
{
    public class ClaseMain
    {
        public static void Main()
        {
            do
            {
                try
                {
                    int menu;
                    Class_menu.menu();
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {

                        case 1:
                            Operadores.Operadores_1();
                            int menu1;
                            menu1 = Convert.ToInt32(Console.ReadLine());
                            switch (menu1)
                            {
                                case 1:
                                    Operadores.op_1(1, 2);
                                    break;

                                case 2:
                                    Operadores.op_2(1, 2);

                                    break;
                                case 3:
                                    Operadores.op_3(1);
                                    break;

                                case 4:
                                    Operadores.op_4(1, 2);
                                    break;

                                case 5:
                                    Operadores.op_5(1);
                                    break;
                                case 6:
                                    Operadores.op_6(1);
                                    break;
                                case 7:
                                    Operadores.op_7(1);
                                    break;
                                case 8:
                                    Operadores.op_8(1, 2, 3);
                                    break;
                                case 9:
                                    Salir.Salir_1();
                                    break;



                            }
                            break;
                        case 2:
                            Condicionales.Condicionales_1();
                            int menu2;
                            menu2 = Convert.ToInt32(Console.ReadLine());
                            switch (menu2)
                            {
                                case 1:
                                    Condicionales.co_1(1);

                                    break;
                                case 2:
                                    Condicionales.co_2(1, 2);
                                    break;
                                case 3:
                                    Condicionales.co_3(1, 2, 3);
                                    break;
                                case 4:
                                    Condicionales.co_4(1, 2);
                                    break;
                                case 5:
                                    Condicionales.co_5(1, 2);
                                    break;
                                case 6:
                                    Condicionales.co_6(1, 2);
                                    break;
                                case 9:
                                    Salir.Salir_1();
                                    break;


                            }
                            break;
                        case 3:
                            Ciclos.Ciclos_1();
                            int menu3;
                            menu3 = Convert.ToInt32(Console.ReadLine());
                            switch (menu3)
                            {
                                case 1:
                                    Ciclos.Ci_1(1);
                                    break;
                                case 2:
                                    Ciclos.ci_2(1);
                                    break;
                                case 3:
                                    Ciclos.ci_3(1);
                                    break;
                                case 4:
                                    Ciclos.ci_4(1);
                                    break;
                                case 5:
                                    Ciclos.ci_5(1);
                                    break;
                                case 6:
                                    Ciclos.ci_6(1, 2, 3);
                                    break;
                                case 7:
                                    Ciclos.ci_7(1, 2);
                                    break;

                                case 9:
                                    Salir.Salir_1();
                                    break;


                            }

                            break;


                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(" El valor ingresado no es valido");
                }

                Console.WriteLine("Presione ENTER para volver");
                Console.ReadKey();
                Console.Clear();

            }while (true);
        }
    }
}
