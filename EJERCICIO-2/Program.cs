using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vip, comp, area;
            Console.WriteLine("Ingrese su nombre: ");
            string nomb = Console.ReadLine();
            Console.WriteLine("¿Es cliente VIP?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            vip = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Desea realizar una compra?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            comp = int.Parse(Console.ReadLine());
            if (comp == 1)
                Console.WriteLine("...Confirmado ");
            else if (comp == 2)
            {
                Console.WriteLine("Gracias por su visita " + nomb);
                Console.ReadKey();
                return;
            }
            
            if (vip == 1)
                Console.WriteLine("Se le aplicará un 20% de descuento por ser cliente VIP");
            else if (vip == 2)
                Console.WriteLine("Se le aplicará 5% de descuento.");
            Console.WriteLine("\nElija el área de atención: ");
            Console.WriteLine("1. Tecnología ");
            Console.WriteLine("2. Hogar ");
            Console.WriteLine("3. Ropa ");
            area = int.Parse(Console.ReadLine());
            switch (area)
            {
                case 1:
                    Console.WriteLine("Será dirigido al Área de Tecnología. ");
                    break;
                case 2:
                    Console.WriteLine("Será dirigido al Área de Hogar. ");
                    break;
                case 3:
                    Console.WriteLine("Será dirigido al Área de Ropa. ");
                    break;
                default:
                    Console.WriteLine("Opción Inválida, será dirigido al Área General. ");
                    break;

            }
            Console.WriteLine("Gracias por su visita " + nomb);
            Console.ReadKey();




        }
    }
}
