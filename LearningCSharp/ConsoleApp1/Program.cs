using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentario
            //Imprimir
            Console.WriteLine("Yay");

            //Input de una tecla
            Console.ReadKey();
            /*
             * Un Comentario mas grande
             */
            //VARIABLES
            //variable byte de 0 - 255
            byte variableByte = 230;
            //Imprimir con cotatenacion
            Console.WriteLine("La variable byte es " + variableByte);

            //variable entera
            int variableInt = 23450;
            Console.WriteLine("La variable Int es " + variableInt);

            //Variable Double
            double variableDouble = 235.64;
            Console.WriteLine("La variable Double es " + variableDouble);

            //Variable Bool
            bool variableBool = true;
            Console.WriteLine("La variable Bool es " + variableBool);

            //Variable Char, solo un caracter entre ''
            char variableChar = 'a';
            Console.WriteLine("La variable Char es " + variableChar);

            //Variable String, cadena de caracteres en ""
            string variableString = "Hola a todos";
            Console.WriteLine("La variable String es " + variableString);

            //Variable Dynamic, el compilador "adivina" el tipo de dato pero puede asignar mas memoria 
            dynamic variableDynamic = "Cualquier tipo de dato";

            //ASIGNACION
            //Asignar valor
            byte valor = 10;
            double num1 = 2, num2 = 3;

            //Reasignar el valor mediante Convert, toma mucho tiempo
            valor = Convert.ToByte(valor + 10);

            //Reasignar mediante operadores += *= /= -=
            valor += 10;

            //Operador suma
            Console.WriteLine("La suma es " + (num1 + num2));

            //Elevar necesita Math
            Console.WriteLine("Elevar es " + Math.Pow(num1, num2));

            double num3, num4;
            string input;
            Console.Write("Ingrese un numero: ");
            input = Console.ReadLine();
            num3 = Convert.ToDouble(input);
            //num3 = 3.56;
            Console.Write("Ingrese un numero: ");
            input = Console.ReadLine();
            //num4 = Convert.ToDouble(input);
            num4 = 0.0;


            try
            {

                Console.WriteLine("num3: " + num3 + " " + "num4: " + num4 + " Cantidad: " + (num3 / num4));


            }
            catch (Exception error)
            {
                Console.WriteLine("ERROR: " + error.Message);
            }

            //Switch

            string dia;
            Console.Write("Escribe un dia:");
            dia = Console.ReadLine();
            switch (dia)
            {
                case "Lunes": Console.WriteLine("Dia lunes"); break;
                default: Console.WriteLine("No es un dia"); break;

            }

            //for
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Es un FOR");
            }

            //for each
            string hola = "HolaMundo";
            foreach (char letra in hola)
            {
                Console.WriteLine(letra);
            }
            //while
            bool boleano = true;

            while (boleano == true)
            {
                Console.WriteLine("Escriba algo");
                boleano = false;
            }
            //do while
            do
            {
                Console.WriteLine("Escriba algo");
                boleano = false;
            }
            while (boleano == false);


            Console.ReadKey();



        }
    }
}
