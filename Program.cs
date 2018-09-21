using System;

namespace triangulo_de_pascal_con_unos_gtesistemas
{
    class Program
    {
              static void Main(string[] args)
        {
            
            Console.WriteLine("Hola, introduce el numero de unos de la base de la piramide:");
            int tope = int.Parse(Console.ReadLine());

            for(int i=1;i<=tope;i++)
            {
                for(int j=1;j<=(tope-i);j++) // escribir los espacios
                Console.Write(" ");          // antes de los unos
                for(int j=1;j<=i;j++)    // escribir los unos
                    Console.Write("1 "); // con espacios intercalados
                Console.Write("\n"); // terminó la línea, avanzar
            }
            Console.ReadLine();

        }
    }
}
