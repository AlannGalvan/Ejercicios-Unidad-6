using System;

namespace punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para recibir listas de números positivos que están separadas entre
            // sí por un cero. El fin de la carga se notifica con un número negativo. 
            //Luego mostrar cuántos números tiene cada lista.

            int n, conNumeros, conGrupo = 0;

            Console.WriteLine("Ingrese un nro Positivo: ");
            n = int.Parse(Console.ReadLine());

            while (n >= 0)
            {   
                conGrupo++;
                conNumeros = 0;
                while (n != 0)
                {   
                     conNumeros++;
                    Console.WriteLine("Ingrese un nro: ");
                    n = int.Parse(Console.ReadLine());
                   
                }
                conNumeros--;
                Console.WriteLine("numero de grupo: " + conGrupo + " numeros ingresados: " + conNumeros);

                Console.WriteLine("Ingrese un nro positivo para hacer otra lista o un nro negativo para terminar... ");
                n = int.Parse(Console.ReadLine());

                
            }

           Console.WriteLine("Fin del programa...");
           
        }
    }
}
