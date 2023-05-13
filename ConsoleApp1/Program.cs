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



            #endregion

            #region Ejercicio 4


            //int[] numEntero = new int[5];
            //int esPar = 0;
            //int numero;

            //for (int i = 0; i < numEntero.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un numero entero");
            //    numEntero[i] = int.Parse(Console.ReadLine());

            //}


            #endregion


            #region Ejercicio 6
            //6.	Fácil: Declara un arreglo de strings con nombres de frutas y muestra en consola
            //el nombre de la primera y última fruta del arreglo.


            //string[] arregloFrutas = new string[5];

            //for (int i = 0; i < arregloFrutas.Length; i++)
            //{
            //    Console.WriteLine("Igrese una palabra");
            //    arregloFrutas[i] = (Console.ReadLine());

            //}

            //    Console.WriteLine(arregloFrutas[3]);
            //    Console.WriteLine(arregloFrutas[2]);

            #endregion

            #region Ejercicio 7

            //7.Fácil: Declara un arreglo de números enteros y muestra en consola los elementos que son mayores a 5.

            //int[] numMayor5 = new int[5];
            //int numero = 0;

            //for (int i = 0; i < numMayor5.Length; i++) 
            //{
            //    Console.WriteLine("Ingrese un numero entero");
            //    numMayor5[i] = int.Parse(Console.ReadLine());
            //    numero = numMayor5[i];
            //}

            //for (int i = 0; i < numMayor5.Length ; i++)
            //{
            //    if (numMayor5[i] > 5)
            //    {
            //        numero++;
            //    }
            //}
            //Console.WriteLine(numero);

            #endregion

            #region Ejercicio 8

            //int[] arrInverso = new int[5];

            //for (int i = 0; i < arrInverso.Length; i++) 
            //{
            //    Console.WriteLine("Ingrese un numero");
            //    arrInverso[i] = int.Parse(Console.ReadLine());
            //        ;
            //}
            //for (int i = 4; i > -1 ;i--)
            //{
            //    Console.WriteLine(arrInverso[i]);
            //}
            #endregion

            #region Ejercicio 9
            //9.Medio: Declara un arreglo de números enteros y un número entero y muestra en consola la cantidad de elementos 
            // del arreglo que son iguales al número entero dado.

            int[] arrEnteros = new int[5];
            int numEntero = 0;

            Console.WriteLine("Ingrese un numero Entero");
            numEntero = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrEnteros.Length; i++)
            {
                Console.WriteLine("ingrese los datos para el arreglo");
                arrEnteros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrEnteros.Length; i++)
            {
                if(numEntero < arrEnteros[i])
                {
                    arrEnteros[i] = arrEnteros[i];
                }
                if(numEntero > arrEnteros[i])
                {
                    arrEnteros[i] = arrEnteros[i];
                }
                else
                {
                    
                }
                Console.WriteLine(arrEnteros);
            }


            #endregion


        }
    }

}
