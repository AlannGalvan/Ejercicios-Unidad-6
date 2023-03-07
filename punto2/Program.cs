using System;

namespace punto2
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros.
            // Se pide determinar e informar:

            //El número de grupo con mayor porcentaje de números impares respecto al total de
            // números que forman el grupo.
            //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            int n, con, conImpar, conNumeros, grupoImparesMaximo, min, conOrdenados;
            double porcentajeImpares, porcentajeMaximo = -1;
            bool banderaOrdenados;

            for (int x = 0; x < 5; x++)
            {
                

                conImpar = 0
                conNumeros = 0;               
                banderaOrdenados = true;               
                Console.WriteLine("Ingrese nro: ");
                n = int.Parse(Console.ReadLine());
                min = 0;
                while (n != 0)
                {   
                    conNumeros++;

                    if(n % 2 != 0)
                      contadorImpar++;

                    //punto b
                    if(n < min)
                       min = n;
                    else  
                     banderaOrdenados = false;                                     
                       
                    
                    n = int.Parse(Console.ReadLine());
                } // termina while..

                //regla de 3 para porcentaje
                //conNumeros -- 100%   = conImpar * 100 / conNumeros.
                //conImpar   --  x     =
                porcentajeImpares = conImpar * 100 / conNumeros;
                if(porcentajeImpares > porcentajeMaximo){
                 porcentajeMaximo = porcentajeImpares;
                 grupoImparesMaximo = x + 1;
                }


                //punto b
                if(banderaOrdenados)
                   conOrdenados++;


            } // termine el for..

            Console.WriteLine("el grupo con mayor porcentaje de impares es: " + grupoImparesMaximo);

            Console.WriteLine("La cantidad de grupos con nro ordenados es: " + conOrdenados);
        }
    }
}
