using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosEjercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 1

            //    Console.WriteLine("Escribe un número");
            //    int num = Int32.Parse(Console.ReadLine());
            //    esPar(num);

            //}

            //public static void esPar(int numRecibido)
            //{
            //    if (numRecibido%2==0)
            //    {
            //        Console.WriteLine("es PAR");
            //    }
            //    else
            //    {
            //        Console.WriteLine("es IMPAR");
            //    }
            //    Console.ReadLine();



            //EJERCICIOS SENCILLOS
            //EJERCICIO 1

            //    greeting();

            //}

            //public static void greeting()

            //{
            //    Console.WriteLine("Buenos dias");
            //    Console.WriteLine("Buenos dias");
            //    Console.WriteLine("Buenos dias");
            //    Console.ReadLine();

            //}


            //EJERCICIO 2

            // Console.WriteLine("Cuantas veces?");
            // int times = Int32.Parse(Console.ReadLine());
            // timeShown(times);
            //}

            //public static void timeShown (int times)
            //{
            //for (int i = 0; i <= times; i++)
            //    {
            //        Console.WriteLine("Buenos dias");
            //    }

            //}

            //EJERCICIO 3

            //    int num1, num2;
            //    Console.WriteLine("escribe número");
            //    num1 = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine("escribe número");
            //    num2 = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine(addTwoNumbers(num1, num2));

            //    Console.ReadLine();

            //}
            //public static int addTwoNumbers(int num1, int num2)
            //{
            //    return num1 + num2;
            //}

            //EJERCICIO 4

            //    int num1, num2;
            //    int sum;
            //    Console.WriteLine("escribe número");
            //    num1 = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine("escribe número");
            //    num2 = Int32.Parse(Console.ReadLine());
            //    sum = addTwoNumbers(num1, num2);
            //    Console.WriteLine(sum);
            //    Console.ReadLine();

            //}
            //public static int addTwoNumbers(int num1, int num2)
            //{
            //    int sum = num1 + num2; 
            //    return sum;
            //}

            //EJERCICIO 5

            //    int num1, num2;
            //    int divide;
            //    do
            //    {
            //        Console.WriteLine("escribe número");
            //        num1 = Int32.Parse(Console.ReadLine());
            //        Console.WriteLine("escribe número");
            //        num2 = Int32.Parse(Console.ReadLine());
            //        if (num2!=0)
            //        {
            //        divide = divideTwoNumbers(num1, num2);
            //        Console.WriteLine(divide);
            //        }
            //        Console.ReadLine();
            //    }
            //    while (num2 != 0);
            //}
            //public static int divideTwoNumbers(int num1, int num2)
            //{
            //    int divide = num1 / num2;
            //    return divide;
            //}

            //EJERCICIO 6

            //    int num1, num2;
            //    Console.WriteLine("escribe número");
            //    num1 = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine("escribe número");
            //    num2 = Int32.Parse(Console.ReadLine());
            //    biggestNumber(num1, num2);
            //    Console.ReadLine();
            //}
            //public static void biggestNumber(int num1, int num2)
            //{
            //    if (num1 < num2)
            //    {
            //        bool verdadero;
            //        verdadero = false;
            //        Console.WriteLine("El primer numero NO mas grande es el segundo");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El primer numero es mas grande es el primero");
            //    }

            //}

            //EJERCICIO 8

            //    int[] valores = { 2, 5, 1, 4, 3, 6, 7, 8, 9, 10 };
            //    ascendant(valores);
            //    descendant(valores);
            //    Console.ReadLine();

            //}
            //public static void ascendant(int[] valores)
            //{
            //    for (int i = 0; i < valores.Length; i++)
            //    {
            //        Array.Sort(valores);
            //        Console.WriteLine(valores[i]);
            //    }
            //}
            //public static void descendant(int[] valores)
            //{
            //    for (int i=0; i < valores.Length; i++)
            //    {
            //        Array.Sort(valores);
            //        Array.Reverse(valores);
            //        Console.Write(" "+ valores[i]);
            //    }

            //EJERCICIO 9

            //    int[] valores = { 2, 3, 5, 7, 4, 1, 6, 8, 9, 10 };

            //    ascendant(valores);
            //    Console.ReadLine();

            //}
            //public static void ascendant (int [] valores)
            //{
            //    bool valor = true;
            //    if (valor)
            //    {
            //        for (int i = 0; i < valores.Length; i++)
            //        {
            //            Array.Sort(valores);
            //            Console.WriteLine(valores[i]);
            //        }

            //    }
            //    else
            //    {
            //        for (int i=0; i<valores.Length; i++)
            //        {
            //            Array.Sort(valores);
            //            Array.Reverse(valores);
            //        }
            //    }


            //EJERCICIO 10
            //    int month;
            //    Console.WriteLine("Escribe un número de mes");
            //    month = Int32.Parse(Console.ReadLine());

            //    month=PedirMes(month);
            //    Console.ReadLine();
            //}
            //public static int PedirMes(int month)
            //{
            //    do
            //    {
            //        Console.WriteLine("El mes no es correcto");
            //        return month;
            //    }
            //    while (month > 1 && month < 12);

            //        Console.WriteLine("El mes es correcto");
            //        return month;
            //}

            
                int month, year1, year2, year3;
                Console.WriteLine("Escribe el mes");
                month = Int32.Parse(Console.ReadLine());
                month=CheckMonth(month);
                Console.WriteLine("Escribe Año");
                year1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Escribe Año");
                year2 = Int32.Parse(Console.ReadLine());
                year3 = 0;
                ChechYear(year1, year2, year3);
                

            }
            public static int CheckMonth(int month)
            {

            while (month < 1 || month > 12) 
            {
                  
            Console.WriteLine("El número de mes no es correcto, introduzca de nuevo");
            month = Int32.Parse(Console.ReadLine());                   
            }
                
                return month;

            }
             public static int CheckYear(int year1, int year2, int year3)
            {
            
            if (year1>year2)
            {
                year3 = year1;
                year1 = year2;
                year2 = year3;

                
            }

            }
            
        }
    }
