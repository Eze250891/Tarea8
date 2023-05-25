using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Funcion declaratoria de arreglo

            static int[] DeclararArreglo()
            {
                int[] arreglo = new int[5];


                for (int i = 0; i < arreglo.Length; i++)
                {
                    Console.WriteLine("Ingrese un numero entero");
                    arreglo[i] = int.Parse(Console.ReadLine());
                }
                return arreglo;
            }

            #endregion

            #region Funcion declaratoria arreglo string
            static string[] DeclararArregloString()
            {
                string[] arregloString = new string[5];
                
                for (int i = 0; i < arregloString.Length; i++)
                {
                    Console.WriteLine("complete el arreglo de string");
                    arregloString[i] = Console.ReadLine();
                }
                return arregloString;
            }
            #endregion

            #region Ejercicios 1
            //1.	Fácil: Declara un arreglo de números enteros
            //a.muestra en consola la suma de todos sus elementos.
            //b.muestra en consola el número más grande de entre todos sus elementos.
            //c.muestra en consola el número más pequeño de entre todos sus elementos.


            //------------------ a -----------------------
            //int[] numEnteros = new int[10];
            //int resultado = 0;
            //int numMayor = 0;
            //int numMenor = 0;

            //for (int i = 0; i < numEnteros.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un numero");
            //    numEnteros[i] = int.Parse(Console.ReadLine()); //Transformo el numero y lo almaceno aca

            //}

            //for (int i = 0; i < numEnteros.Length; i++)
            //{
            //    resultado += numEnteros[i]; //Aca almaceno y sumo el numero nuevo o siguiente

            //    if (i == 0) // aca ingreso el primer numero al indice cero 0 y lo almaceno para luego compararlo
            //    {
            //        numMayor = numEnteros[i]; // almaceno el mismo numero en cada variable para luego ir comparando y descartando
            //        numMenor = numEnteros[i];
            //    }

            //    if (numEnteros[i] >= numMayor) // aca comparo esa variable numMayor con los numeros siguientes del arreglo
            //    {
            //        numMayor = numEnteros[i];
            //    }
            //    if (numEnteros[i] < numMenor)
            //    {
            //        numMenor = numEnteros[i];
            //    }

            //}

            //Console.WriteLine($"El Resulado de la suma de todos los numeros ingresados es {resultado}");
            //Console.WriteLine($"el numero mayo de este arreglo es el {numMayor}");
            //Console.WriteLine($"el numero mayo de este arreglo es el {numMenor}");

            //------------------ b -----------------------

            //int[] num = new int[10];
            //int numMayor = 0;

            //for (int i = 0; i < num.length; i++)
            //{
            //    console.writeline("ingrese un num");
            //    num[i] = int.parse(console.readline());

            //}

            //for (int i = 0; i < num.length; i++)
            //{
            //    if (i == 0) // aca ingreso el primer numero y luego comparo
            //    {
            //        numMayor = num[i];
            //    }

            //    if (num[i] >= numMayor) // aca comparo esa variable nummayor con los numeros siguientes del arreglo
            //    {
            //        numMayor = num[i];
            //    }
            //}

            //console.writeline($"el numero mayo de este arreglo es el {numMayor}");


            //------------------ c -----------------------

            //int[] numP = new int[5];
            //int numMenor = 0;

            //for (int i = 0; i < numP.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un dato");
            //    numP[i] = int.Parse(Console.ReadLine());

            //}

            //for (int i = 0; i < numP.Length; i++)
            //{
            //    if (i == 0)
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
            //int[] arregloSegundo = new int[5]; // no hace falta iniciar las variables antes, mejor en el lugar que se van a usar
            //int resultado1 = 0;


            //int numMayor1 = 0;
            //int numMenor1 = 0;



            //for (int i = 0; i < arregloPrimero.Length; i++)
            //{
            //    Console.WriteLine("ingrese un numero para el primero arreglo");
            //    arregloPrimero[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < arregloPrimero.Length; i++)
            //{
            //    resultado1 += arregloPrimero[i]; // almaceno y cada numero del arreglo en esa variable

            //    if (i == 0)
            //    {
            //        numMayor1 += arregloPrimero[i]; //almaceno el primero numero en cada una de estas variable
            //        numMenor1 += arregloPrimero[i];
            //    }
            //    if (arregloPrimero[i] > numMayor1) // aca comparo ese num guardado contra cada indice del arreglo
            //    {
            //        numMayor1 = arregloPrimero[i]; // si el numero ingresado en el indice es mayor al anterior, pasa a reemplazarlo
            //    }

            //    if (arregloPrimero[i] < numMenor1) //lo mismo pero se reemplaza con un numero menor 
            //    {
            //        numMenor1 = arregloPrimero[i];
            //    }

            //}

            //for (int i = 0; i < arregloSegundo.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un numero para el segundo arreglo");
            //    arregloSegundo[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < arregloSegundo.Length; i++)
            //{
            //    resultado1+= arregloSegundo[i];  // aca a la suma final del primer arreglo, continuo sumando los datos ingresados de cada indice del 2do arreglo

            //    if (arregloSegundo[i] >= numMayor1)  //comparo el numero mayor del primer arreglo contra todos los ingresados en el arreglo 2
            //    {
            //        numMayor1 = arregloSegundo[i]; // si alguno del arreglo2 es mayor al resultado del mayor arreglo1 entonces lo reemplaza
            //    }
            //    if (arregloSegundo[i] <= numMenor1) // lo mismo pero con el menor
            //    {
            //        numMenor1 = arregloSegundo[i];
            //    }
            //}

            //Console.WriteLine(numMayor1);
            //Console.WriteLine(numMenor1);
            //Console.WriteLine(resultado1);

            #endregion

            #region Ejercicio 3

            //3.Fácil: Declara un arreglo de números enteros y un número entero y muestra en consola la cantidad de elementos del arreglo
            //que son mayores que el número entero dado.

            //int[] arreglo = new int[5];


            //for (int i = 0; i < arreglo.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un dato para completar el arreglo");
            //    arreglo[i] = int.Parse(Console.ReadLine()); //relleno el arreglo con los datos ingresados
            //}

            //Console.WriteLine("ingresa el numero entero");
            //int numero = int.Parse(Console.ReadLine()); //ingreso el numero entero
            //int contador = 0;

            //for (int i = 0;i < arreglo.Length; i++)
            //{
            //    if (arreglo[i] > numero) //si los numeros en el arreglo son mayores al numero entero, cuenta +1
            //    {
            //        contador++; //cuenta la cantidad de veces que son mayores a ese numero ingresado
            //    }
            //}
            //Console.WriteLine(contador);




            #endregion

            #region Ejercicio 4
            //Declara un arreglo de números enteros y muestra en consola los elementos que son pares.

            //int[] arregloPar = new int[5];

            //for (int i = 0; i < arregloPar.Length; i++)
            //{
            //    Console.WriteLine("Ingrese datos para completar el arreglo");
            //    arregloPar[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0;i < arregloPar.Length;i++)
            //{
            //    if (arregloPar[i] % 2 ==0)
            //    {
            //        Console.WriteLine(arregloPar[i]);
            //    }
            //}



            #endregion

            #region Ejercicio 5

            //int[] numImpar = new int[5];

            //for (int i = 0; i < numImpar.Length; i++)
            //{
            //    Console.WriteLine("Ingrese numeros enteros para completar el arreglo");
            //    numImpar[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < numImpar.Length; i++)
            //{
            //    if (numImpar[i] % 2 != 0)
            //    {
            //        Console.WriteLine(numImpar[i]);
            //    }
            //}


            #endregion

            #region Ejercicio 6
            //6.Fácil: Declara un arreglo de strings con nombres de frutas y muestra en consola
            //el nombre de la primera y última fruta del arreglo.


            //string[] arregloFrutas = new string[5];

            //for (int i = 0; i < arregloFrutas.Length; i++)
            //{
            //    Console.WriteLine("Igrese una palabra");
            //    arregloFrutas[i] = (Console.ReadLine());

            //}

            //Console.WriteLine(arregloFrutas[0]);
            //Console.WriteLine(arregloFrutas[arregloFrutas.Length-1]);

            #endregion

            #region Ejercicio 7

            //7.Fácil: Declara un arreglo de números enteros y muestra en consola los elementos que son mayores a 5.

            //int[] numMayor5 = new int[5];
            //int numero = 0;

            //for (int i = 0; i < numMayor5.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un numero entero");
            //    numMayor5[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < numMayor5.Length; i++)
            //{
            //    if (numMayor5[i] > 5)
            //    {
            //        numero++;
            //    }
            //}
            //Console.WriteLine(numero);

            #endregion

            #region Ejercicio 8

            //8.Fácil: Declara un arreglo de números enteros y muestra
            //  en consola los elementos del arreglo en orden inverso.

            //int[] arrInverso = new int[5];

            //for (int i = 0; i < arrInverso.Length; i++)
            //{
            //   Console.WriteLine("Ingrese un numero");
            //   arrInverso[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 4; i >= 0; i--)
            //{
            //   Console.WriteLine(arrInverso[i]);
            //}
            #endregion

            #region Ejercicio 9
            //9.Medio: Declara un arreglo de números enteros y un número entero y muestra en consola la cantidad de elementos 
            // del arreglo que son iguales al número entero dado.

            //int[] arrEnteros = new int[5];
            //int numEntero = 0;
            //int contador = 0;    

            //Console.WriteLine("Ingrese un numero Entero");
            //numEntero = int.Parse(Console.ReadLine());


            //for (int i = 0; i < arrEnteros.Length; i++)
            //{
            //    Console.WriteLine("ingrese los datos para el arreglo");
            //    arrEnteros[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < arrEnteros.Length; i++)
            //{
            //    if (arrEnteros[i] == numEntero)
            //    {
            //        contador++;
            //    }
            //}

            //Console.WriteLine(contador);



            #endregion

            #region Ejercicio 10

            //10.Medio: Declara un arreglo de números enteros y muestra en consola
            //   la cantidad de elementos pares que tiene.

            //int[] par = new int[6];
            //int contadorPar = 0;

            //for (int i = 0; i < par.Length; i++) 
            //{
            //    Console.WriteLine("Ingrese un dato para llenar el arreglo");
            //    par[i] = int.Parse(Console.ReadLine());   
            //}

            //for (int i = 0; i <  par.Length; i++) 
            //{
            //    if (par[i] % 2 == 0)
            //    {
            //        contadorPar++;
            //    }
            //}
            //Console.WriteLine(contadorPar++);


            #endregion

            #region Ejercicio 11
            //11.	Medio: Declara un arreglo de números enteros y muestra en consola
            //la cantidad de elementos impares que tiene.

            //int[] arregloImpar = new int[8];
            //int contadorImpar = 0;

            //for (int i = 0; i < arregloImpar.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un numero para completar el arreglo");
            //    arregloImpar[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < arregloImpar.Length; i++)
            //{
            //    if (arregloImpar[i] % 2 != 0)
            //    {
            //        contadorImpar++;
            //    }
            //}
            //Console.WriteLine(contadorImpar);

            #endregion

            #region Ejercicio 12
            // 12.	Medio: Declara un arreglo de números enteros y
            // muestra en consola el promedio de todos sus elementos.

            //double[] arrPromedio = new double  [5];
            //double promedio = 0;

            //for (int i = 0; i < arrPromedio.Length; i++)
            //{
            //    Console.WriteLine("ingrese los datos para el arreglo");
            //    arrPromedio[i] = double.Parse(Console.ReadLine());
            //}

            //for (int i = 0;i < arrPromedio.Length;i++)
            //{
            //    promedio += arrPromedio[i];
            //}
            //Console.WriteLine(promedio);
            //Console.WriteLine($"El promedio es {promedio / arrPromedio.Length}");

            #endregion

            #region Ejercicio 13
            // Declara dos arreglos de números enteros y muestra en consola los elementos que tienen en común.

            //int[] arreglo1 = new int[3];

            //for (int i = 0; i < arreglo1.Length; i++)
            //{
            //    Console.WriteLine("Ingrese los datos para el primer arreglo");
            //    arreglo1[i] = int.Parse(Console.ReadLine());
            //}

            //int[] arreglo2 = new int[3];

            //for (int i = 0; i < arreglo2.Length; i++)
            //{
            //    Console.WriteLine("Ingrese los datos para el segundo arreglo");
            //    arreglo2[i] = int.Parse(Console.ReadLine());
            //}

            //int[] arreglo3 = new int[6];
            //int indiceResultado = 0;
            //// recorro el primero arreglo

            //for (int i = 0; i < arreglo1.Length; i++)
            //{
            //    for (int j = 0; j < arreglo2.Length; j++) //primero compara toda i contra j y cuando termina pasa al siguiente i
            //    {
            //        if (arreglo1[i] == arreglo2[j])
            //        {
            //            arreglo3[indiceResultado] = arreglo1[i]; //aca se almacena en el indice 0, el primer numero igualado
            //            indiceResultado++;
            //        }
            //    }
            //}
            //for (int i = 0; i < indiceResultado; i++)
            //{
            //    Console.WriteLine($"se repite {arreglo3[i]}");
            //}
            #endregion

            #region Ejercicio 14  incompleto
            //int[] arreglo1 = new int[5];

            //for (int i = 0; i < arreglo1.Length; i++)
            //{
            //    Console.WriteLine("Ingrese los datos para el primer arreglo");
            //    arreglo1[i] = int.Parse(Console.ReadLine());

            //}

            //int[] arreglo2 = new int[5];

            //for (int i = 0; i < arreglo2.Length; i++)
            //{
            //    Console.WriteLine("Ingrese los datos del segundo arreglo");
            //    arreglo2[i] = int.Parse(Console.ReadLine());
            //}

            //int[] arreglo3 = new int[5];
            //int contadorIndice = 0;

            //for (int i = 0; i < arreglo1.Length; i++)
            //{
            //    for (int j = 0; j < arreglo2.Length; i++)
            //    {
            //        if (arreglo1.Length != arreglo2.Length)
            //        {
            //            arreglo3[contadorIndice] = arreglo1[i];
            //            contadorIndice++;
            //        }
            //        else
            //        {
            //            arreglo3[contadorIndice] = 0;
            //        }
            //    }
            //}

            //for (int i = 0; i < contadorIndice; i++)
            //{
            //    Console.WriteLine($"No repite {arreglo3[i]}");
            //}

            #endregion

            #region Ejercicio 17

            //Declara un arreglo de números enteros y muestra en consola los
            //elementos que están en posiciones impares del arreglo.

            //int[] arregloImpar = new int[5];

            //for (int i = 0; i < arregloImpar.Length; i++)
            //{
            //    Console.WriteLine("Complete el arreglo");
            //    arregloImpar[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < arregloImpar.Length; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(arregloImpar[i]);
            //    }
            //}


            #endregion

            #region Ejercicio 18
            //Declara un arreglo de números enteros y muestra en consola los elementos
            //    que están en posiciones pares del arreglo.

            //int[] arregloPar = new int[5];

            //for (int i = 0; i < arregloPar.Length; i++)
            //{
            //    Console.WriteLine("Complete el arreglo");
            //    arregloPar[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0;i < arregloPar.Length;i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(arregloPar[i]);
            //    }
            //}




            #endregion

            #region Ejercicio 19

            //Declara un arreglo de números enteros y encuentra la suma de todos
            //    los elementos que están en posiciones pares.

            //int[] arregloPosPar = new int[10]; // sumando del 1 al 10, da 25
            //int sumaTotal = 0;

            //for (int i = 0; i < arregloPosPar.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un numero para completar el Arreglo");
            //    arregloPosPar[i] = int.Parse(Console.ReadLine());    
            //}

            //for (int i = 0;i < arregloPosPar.Length;i++)
            //{
            //    if(i % 2 == 0) // aca le digo que solo cuando i sea par almacene y sume
            //    {
            //        sumaTotal += arregloPosPar[i];//almacena y suma
            //    }
            //}

            //Console.WriteLine(sumaTotal);



            #endregion

            #region Ejercicio 20

            //Declarar un arreglo de números enteros y mostrar en consola los elementos
            //que están en posiciones que son múltiplos de 3.

            //int[] arregloMulti = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };

            //for (int i = 0; i < arregloMulti.Length; i++)
            //{
            //    Console.WriteLine("Complete el arreglo");     ////// comento eso asi uso el arreglo mas largo predeterminado
            //    arregloMulti[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < arregloMulti.Length; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(arregloMulti[i]);
            //    }
            //}


            #endregion

            #region Ejercicio 21

            //Declarar un arreglo de números enteros y un número entero y
            //muestra en consola los elementos del arreglo que son mayores que el
            //número entero dado y que están en posiciones impares.


            //Console.WriteLine("Ingrese un numero entero");
            // int numEntero = int.Parse(Console.ReadLine());

            //int[] arregloIpar = new int[5];

            //for (int i = 0; i < arregloIpar.Length; i++)
            //{
            //    Console.WriteLine("Complete el arreglo");
            //    arregloIpar[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < arregloIpar.Length; i++)
            //{
            //    if (arregloIpar[i] >= numEntero)
            //    {
            //         if(i % 2 != 0)
            //         {
            //           Console.WriteLine(arregloIpar[i]);
            //         }
            //    }

            //}

            #endregion

            #region Ejercicio 23 //sin hacer
            //Declarar un arreglo de números enteros y ordena los elementos de manera
            //ascendente y muestra el arreglo ordenado en consola.


            #endregion

            #region Ejercicio 26

            // Declarar un arreglo de strings y cuenta la cantidad de elementos
            // que empiezan con una letra específica.
            // Muestra el resultado en consola.

            //string letra;
            //Console.WriteLine("ingrese una letra");
            //letra = Console.ReadLine();

            //string [] arregloString = new string[5];
            //int contadorLetra = 0;

            //for (int i = 0; i < arregloString.Length; i++)
            //{
            //    Console.WriteLine("ingrese una palabra para llenar el arreglo");
            //    arregloString[i] = Console.ReadLine();

            //}

            //for (int i = 0;i < arregloString.Length;i++)
            //{
            //    if (arregloString[i].StartsWith(letra.ToString()))
            //    {
            //        contadorLetra++;
            //    }
            //}

            //Console.WriteLine(contadorLetra);



            #endregion

            #region Ejercicio 27 

            //int[] arreglo1 = new int[5];

            //for (int i = 0; i < arreglo1.Length; i++)
            //{
            //    Console.WriteLine("Complete el arreglo 1");
            //    arreglo1[i] = int.Parse(Console.ReadLine());
            //}

            //int[] arreglo2 = new int[5];

            //for (int i = 0; i < arreglo2.Length; i++)
            //{
            //    Console.WriteLine("Complete el arreglo 2");
            //    arreglo2[i] = int.Parse(Console.ReadLine());
            //}
            //int[] arreglo3 = new int[5];
            //int indice = 0;

            //for (int i = 0; i < arreglo1.Length; i++)
            //{
            //    for (int j = 0; j < arreglo2.Length; j++)
            //    {
            //        if (arreglo1[i] == arreglo2[j])
            //        {
            //            arreglo3[indice] = (arreglo1[i]);
            //            indice++;
            //        }
            //    }
            //}

            //for (int i = 0; i < indice; i++)
            //{
            //    Console.WriteLine(arreglo3[i]);
            //}


            #endregion

            #region Ejercicio 28

            //string[] arregloString = new string[5];

            //for (int i = 0; i < arregloString.Length; i++)
            //{
            //    Console.WriteLine("complete el arreglo de string");
            //    arregloString[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < arregloString.Length; i++)
            //{
            //    if (arregloString[i].Length > 5)
            //    {
            //        Console.WriteLine(arregloString[i]);
            //    }
            //}

            #endregion

            #region Ejercicio 29

            int[] arreglo1 = new int[5];

            for (int i = 0; i < arreglo1.Length; i++)
            {
                Console.WriteLine("Complete el arreglo 1");
                arreglo1[i] = int.Parse(Console.ReadLine());
            }

            int[] arreglo2 = new int[5];

            for (int i = 0; i < arreglo2.Length; i++)
            {
                Console.WriteLine("Complete el arreglo 2");
                arreglo2[i] = int.Parse(Console.ReadLine());
            }
            int[] arreglo3 = new int[5];
            int indice = 0;

            for (int i = 0; i < arreglo2.Length; i++)
            {
                for (int j = 0; j < arreglo1.Length; j++)
                {
                    if (arreglo1[j] != arreglo2[i] )
                    {
                        arreglo3[indice] = arreglo1[i];
                        indice++;
                    }
                }
            }

            for (int i = 0; i < indice; i++)
            {
                Console.WriteLine(arreglo3[i]);
            }
            #endregion

        }
    }

}
