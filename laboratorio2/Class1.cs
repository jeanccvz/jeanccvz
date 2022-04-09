using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio2
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            // declaración de variables
            double numero1, numero2, resultado = 0;
            int opcion;

            //Solicitar el ingreso por teclado
            Console.WriteLine("╔══════════════════════════╗");
            Console.WriteLine("║ Operaciones  Aritméticas ║");
            Console.WriteLine("╚══════════════════════════╝");

            Console.WriteLine("Ingrese Numero 1: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Numero 2: ");
            numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese opcion a realizar (1-4)");
            opcion = int.Parse(Console.ReadLine());

            // Realizando el calculo en función a la operación

            if (opcion > 0 & opcion < 5)
            {
                switch (opcion)
                {
                    case 1:
                        resultado = numero1 + numero2;
                        Console.WriteLine("La suma es :" + resultado);
                        Console.ReadKey();
                        break;
                    case 2:
                        resultado = numero1 - numero2;
                        Console.WriteLine("La resta es :" + resultado);
                        Console.ReadKey();
                        break;
                    case 3:
                        resultado = numero1 * numero2;
                        Console.WriteLine("La multiplicaicon es :" + resultado);
                        Console.ReadKey();
                        break;
                    case 4:
                        if (numero2 > 0)
                        {
                            resultado = numero1 / numero2;
                            Console.WriteLine("La division es :" + resultado);
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No se puede hacer la division");
                            break;
                        }
                }
            }
            else
                {
                 Console.WriteLine("opcion invalida");
                 Console.ReadKey();
                        
                }

            }
        }
    }




    
    

