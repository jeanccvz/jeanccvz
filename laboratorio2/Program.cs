using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string estadocivil;
            int edad;
            double salario;

            Console.WriteLine("Ingresa el estado civil");
            estadocivil = System.Console.ReadLine();

            Console.WriteLine("Ingresa su edad");
            edad = int.Parse(System.Console.ReadLine());

            Console.WriteLine("Ingresa su salario");
            salario = double.Parse(System.Console.ReadLine());

            //realizar la funcionalidad

            if (estadocivil.Equals("casado") && edad >= 18 && salario > 2500)
            {
                System.Console.WriteLine("Prestamo aprobado");
            }
            else if (estadocivil.Equals("casado") && edad >= 18 && (salario > 900 && salario <= 2500))
            {
                System.Console.WriteLine("Prestamo no aprobado");
            }
            else
            {
                System.Console.WriteLine("No cumples con las condiciones para solicitar un prestamo");
            }
            //impresion en pantalla
            Console.ReadKey();
        }
    }
}
