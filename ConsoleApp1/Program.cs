using System;
using System.Globalization;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicios 1
            //1.	Fácil: Declara un arreglo de números enteros
            //a.muestra en consola la suma de todos sus elementos.
            //b.muestra en consola el número más grande de entre todos sus elementos.
            //c.muestra en consola el número más pequeño de entre todos sus elementos.


            //------------------ a -----------------------
            //int[] numEnteros = new int[10];
            //int resultado = 0;

            //for (int i = 0; i < numEnteros.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un numero");
            //    numEnteros[i] = int.Parse(Console.ReadLine()); //Transformo el numero y lo almaceno aca

            //}

            //for (int i = 0; i < numEnteros.Length; i++)
            //{
            //    resultado += numEnteros[i]; //Aca almaceno y sumo el numero nuevo
            //}

            //Console.WriteLine($"El Resulado de la suma de todos los numeros ingresados es {resultado}");

            //------------------ b -----------------------

            //int[] num = new int[10];
            //int numMayor = 0;

            //for (int i = 0; i < num.Length; i++) 
            //{
            //    Console.WriteLine("Ingrese un num");
            //    num[i] = int.Parse(Console.ReadLine());

            //    if (num[i] == 0)
            //    {
            //        numMayor += num[i];
            //    }

            //    if (num[i] > numMayor)
            //    {
            //        numMayor = num[i];
            //    }
            //}

            //Console.WriteLine($"El numero mayo de este arreglo es el {numMayor}");


            //------------------ c -----------------------

            //int[] numP = new int[5];
            //int numMenor = 0;

            //for (int i = 0; i < numP.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un dato");
            //    numP[i] = int.Parse(Console.ReadLine());

            //    if (i == 0) // no anda cuando ponia if (numP[i] == 0)
            //    {
            //        numMenor += numP[i];
            //    }

            //    if (numP[i] < numMenor)
            //    {
            //        numMenor = numP[i];
            //    }
            //}

            //Console.WriteLine($"El numero menor de este arreglo es el {numMenor}");



            #endregion

            #region Erjecicios 2

            // 2.Fácil: Declara dos arreglos de números enteros
            //  a.muestra en consola la suma de los elementos de ambos arreglos.
            //  b.muestra en consola el elemento más grande de entre los dos arreglos.
            //  c.muestra en consola el elemento más pequeño de entre los dos arreglos.


            //-------------------------------- a --------------------------------
            //int[] arregloPrimero = new int[5];
            //int[] arregloSegundo = new int[5];
            //int resultado1 = 0;
            //int resultado2 = 0;



            //for (int i = 0; i < arregloPrimero.Length; i++) 
            //{
            //    Console.WriteLine("ingrese un numero para el primero arreglo");
            //    arregloPrimero[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0;i < arregloPrimero.Length; i++)
            //{
            //    resultado1 += arregloPrimero[i];
            //}

            //for (int i = 0; i < arregloSegundo.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un numero para el segundo arreglo");
            //    arregloSegundo[i] = int.Parse(Console.ReadLine());
            //}

            //for(int i = 0; i <arregloSegundo.Length ; i++)
            //{
            //    resultado2 += arregloSegundo[i];
            //}

            //Console.WriteLine($"La suma de los dos arreglos da = {resultado1+resultado2}");

            //-------------------------------- b --------------------------------

            //int[] arreglo1 = new int[5];
            //int[] arreglo2 = new int[5];
            //int numMayor1 = 0;
            //int numMayor2 = 0;
           

            //for (int i = 0; i < arreglo1.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un numero para el primer arreglo");
            //    arreglo1[i] = int.Parse(Console.ReadLine());

            //    if (arreglo1[i] == 0)
            //    {
            //        numMayor1 += arreglo1[i];
            //    }
            //    if (arreglo1[i] > numMayor1)
            //    {
            //     numMayor1 = arreglo1[i];
            //    }
            //}

            //for (int i = 0; i < arreglo2.Length; i++)
            //{
            //    Console.WriteLine("ingrese un numero para el segundo arreglo");
            //    arreglo2[i] = int.Parse(Console.ReadLine());

            //    if (arreglo2[i] == 0)
            //    {
            //        numMayor2 += arreglo2[i];
            //    }
            //    if (arreglo2[i] > numMayor2)
            //    {
            //        numMayor2 = arreglo2[i];
            //    }
            //}

            //if(numMayor1 >= numMayor2)
            //{
            //    Console.WriteLine(numMayor1);
            //}

            //else
            //{
            //    Console.WriteLine(numMayor2);
            //}


            //-------------------------------- c --------------------------------


            //int[] arreglo1 = new int[5];
            //int[] arreglo2 = new int[5];
            //int numMenor1 = 0;
            //int numMenor2 = 0;
            

            //for (int i = 0; i < arreglo1.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un numero para el primer arreglo");
            //    arreglo1[i] = int.Parse(Console.ReadLine());

            //    if (i == 0)  //si pongo arreglo1[i] no funca
            //    {
            //        numMenor1 += arreglo1[i];
            //    }
            //    if (arreglo1[i] < numMenor1)
            //    {
            //        numMenor1 = arreglo1[i];
            //    }
            //}

            //for (int i = 0; i < arreglo2.Length; i++)
            //{
            //    Console.WriteLine("ingrese un numero para el segundo arreglo");
            //    arreglo2[i] = int.Parse(Console.ReadLine());

            //    if (i == 0)  //si pongo arreglo2[i] no funca
            //    {
            //        numMenor2 += arreglo2[i];
            //    }
            //    if (arreglo2[i] < numMenor2)
            //    {
            //        numMenor2 = arreglo2[i];
            //    }
            //}

            //if (numMenor1 <= numMenor2)
            //{
            //    Console.WriteLine(numMenor1);
            //}

            //else
            //{
            //    Console.WriteLine(numMenor2);
            //}


        }
          


            #endregion


        }
    }
