using System;
using System.Linq;

namespace LABORATORIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionPrincipal = 0;
            int[] arreglo = new int[5];
            int[,] matriz = new int[9,16];
            while (opcionPrincipal != 5)
            {
                Console.Clear();
                opcionPrincipal = menuPrincipal();
                if (opcionPrincipal == 1)
                {
                    arreglo = sumaEspecial();
                }
                if (opcionPrincipal == 2)
                {
                    ordenarArreglo(arreglo);
                }
                if (opcionPrincipal == 3)
                {
                    matriz=trianguloPascal();
                }
                if (opcionPrincipal == 4)
                {
                    //fibonacci(matriz);
                    Console.WriteLine("Opcion NO Disponible");
                    Console.ReadKey();
                }
            }


        }

        /*no funciona
        private static void fibonacci(int[,] matriz)
        {
            int sumaDiagonal = 0;
            int sumadiagonal = 0;
            for (int i = 0; i < matriz.GetLength(0) && i < matriz.GetLength(1); i++)
            {
                sumaDiagonal += matriz[i, i];
                Console.WriteLine("La suma de la diagonal es: "+sumaDiagonal);
            }

            
            Console.ReadKey();
        }
        */


        private static int[,] trianguloPascal()
        {
            int filas = 0;
            int columnas = 0;
            int numero = 9;
            int[,] matriz = new int[numero + 1, numero + 1];

            Console.WriteLine("\nTriangulo de Pascal con 9 filas:\n");
            for (filas = 1; filas <= numero; filas++)
            {
                for (columnas = 1; columnas <= numero; columnas++)
                {
                    if (((columnas == 1) | (filas == columnas)))
                    {
                        matriz[filas, columnas] = 1;
                    }
                    else
                    {
                        matriz[filas,columnas] = matriz[filas - 1, columnas] + matriz[filas - 1, columnas - 1];
                    }
                }
            }
            
            for (filas = 1; filas <= numero; filas++)//imprime matriz
            {

                for (columnas = 1; columnas <= numero; columnas++)
                {
                    if ((matriz[filas, columnas] != 0))
                    {
                        Console.Write("{0} ", matriz[filas, columnas]);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            return matriz;
        }

    




        private static void ordenarArreglo(int [] arreglo)//Recibe el arreglo que se lleno en la opcion 1 por parametros
        {
            Console.WriteLine("\nSe utiliza la misma lista de numeros de la opcion uno.");
            Console.WriteLine("\nSi aparecen ceros por favor digite la opcion 1 de primero.");
            int posicion = 0;
            int auxiliar = 0;
            int contador = 0;
            int menor = 0;
            Console.WriteLine("\n\tOrdenar Arreglo ");
            Console.WriteLine("\nArreglo inicial: ");
            for (int b = 0; b < arreglo.Length; b++)//imprime arreglo sin ordenar
            {
                int elemento = arreglo[b];
                Console.Write(elemento);
                Console.Write(", ");

            }

            for (int i = 0; i < arreglo.Length - 1; i++)//ordenando el arreglo
            {
                
                menor = arreglo[i];
                posicion = i;

                for (int c = i + 1; c < arreglo.Length; c++)
                {
                    
                    if (arreglo[c] < menor)
                    {
                        menor = arreglo[c];
                        posicion = c;
                    }
                }

                if (posicion != i)
                {
                    auxiliar = arreglo[i];
                    arreglo[i] = arreglo[posicion];
                    arreglo[posicion] = auxiliar;

                }
                contador = contador + 1;
            }
            Console.WriteLine("\nArreglo ordenado: ");
            for (int c = 0; c < arreglo.Length; c++)//imprime arreglo ordenado
            {
                int elemento = arreglo[c];
                Console.Write(elemento);
                Console.Write(", ");

            }
            Console.WriteLine("\nCantidad de veces recorrido el arreglo: \n"+contador);
            Console.ReadKey();
        }


        private static int[] sumaEspecial()
        {
            int[] arregloSuma = new int[5];
            try
            {
                Console.Clear();
                Console.WriteLine("\n\tSuma Especial");
                Console.WriteLine("\nPor favor digite 5 numeros: \n");
                
                double resultado = 0;
                for (int i = 0; i < arregloSuma.Length; i++)
                {
                    Console.WriteLine("Digite numero " + (i + 1) + ":");
                    int numero = int.Parse(Console.ReadLine());
                    arregloSuma[i] = numero;
                    resultado = resultado + (Math.Pow(arregloSuma[i], i));
                }
                Console.WriteLine("\nEl arreglo es el siguiente: ");
                for (int c = 0; c < arregloSuma.Length; c++)
                {
                    int elemento = arregloSuma[c];
                    Console.Write(elemento);
                    Console.Write(", ");

                }
                Console.WriteLine("\nEl resultado: " + resultado);
                Console.ReadKey();
                
            }
            catch(Exception e)
            {
                Console.WriteLine("Digite solo numeros o llene los cinco numeros solicitados...");
                Console.ReadKey();
            }
            return arregloSuma;

        }


        private static int menuPrincipal()
        {
            int opcion = 0;
            
             Console.WriteLine("\t\nJuego de Listas");
             Console.WriteLine("\n1.Suma Especial");
             Console.WriteLine("2.Ordenar Arreglos");
             Console.WriteLine("3.Crear Triangulo Pascal");
             Console.WriteLine("4.Serie de Fibbonacci");
             Console.WriteLine("5.Salir");
             Console.WriteLine("\nDigite la opcion que desea realizar:");
             opcion = int.Parse(Console.ReadLine());
            

            return opcion;
        }
    }
}
