using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EstructucrasSRS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            1.Estructuras de Salto
            //Ejercicio 1: Encuentra el primer múltiplo de 5
            //Crea un programa que utilice un bucle for para recorrer los números del 1 al 100 y
            //detén la ejecución del bucle cuando encuentres el primer múltiplo de 5 utilizando break.

            //int i = 1;
            ////       while (i < 100)

            ////{
            ////    i++;

            ////    if (i % 5 == 0)
            ////    {
            ////        break;
            ////    }

            //Ejercicio 2: Salta los números pares
            //Escribe un programa que imprima los números del 1 al 20, pero que salte los números pares utilizando continue.
            //int i = 1;
            //while (i < 20) {
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //    }
            //    else { i++; }


            //Ejercicio 3: Reiniciar la entrada con goto
            //Crea un programa que solicite al usuario un número positivo.Si el número ingresado es negativo,
            //utiliza goto para reiniciar la entrada hasta que se ingrese un valor válido.

            //Console.WriteLine("Introduce un número: ");
            //int i = Int32.Parse(Console.ReadLine());

            //if (i < 0)
            //{
            //    Console.WriteLine("Introduce un número válido:");
            //}
            //else {Console.WriteLine("Tu número es válido. Has elegido {i}.");

            //Ejercicio 4: Salida temprana con return
            //Escribe un programa que pida al usuario un número. Si el número es mayor que 50,
            //muestra un mensaje indicando que es demasiado grande y termina la ejecución con return.

            //Console.WriteLine("Introduce un número menor que 50:");
            //int i = Int32.Parse(Console.ReadLine());

            //while (i > 50) 
            //{
            //    Console.WriteLine("Repite.Introduce un número válido.");
            //    i = Int32.Parse(Console.ReadLine()); 
            //}
            // if (i < 50 ) {
            //    Console.WriteLine("El número es válido.");

            //2.Estructuras de Repetición
            //Ejercicio 5: Genera una tabla de multiplicar
            //Escribe un programa que pida al usuario un número y luego utilice un bucle for para generar y mostrar su tabla de multiplicar del 1 al 10.

            //Console.WriteLine("Introduce el número que quieras multiplicar.");
            //int i = int.Parse(Console.ReadLine());

            //for (int j = 1; j <= 10; j++)
            //{
            //    Console.Write(j * i + " ");
            //}

            //Ejercicio 6: Encuentra la suma de números hasta que el usuario diga "no"
            //Crea un programa que utilice un bucle do -while para sumar números ingresados por el usuario.
            //Permite que el usuario decida si desea continuar ingresando números o finalizar.

            //string k = "";
            //do
            //{
            //    Console.WriteLine("Introduce el primer número.");
            //    int i = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Introduce el segundo número.");
            //    int j = int.Parse(Console.ReadLine());
            //    Console.WriteLine(i + j);
            //    Console.WriteLine("¿Quieres continuar? Escribe Sí para continuar.");
            //    k = Console.ReadLine();
            //} while (k == "Sí");



            //Ejercicio 7: Factorial de un número
            //Diseña un programa que solicite un número al usuario y utilice un bucle while para calcular su factorial.

            //Console.WriteLine("Introduce un número para hacer su factorial.");
            //int i = Int32.Parse(Console.ReadLine());
            //int fact = i;
            //for (int j = 1; j <= i; j++) {
            //    Console.WriteLine(fact = fact * j);                
            //}

            //Ejercicio 8: Cuenta regresiva
            //Crea un programa que haga una cuenta regresiva del 10 al 1 utilizando un bucle for, y al final muestra un mensaje de "¡Despegue!".


            //for (int i = 10; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //    if (i == 1)
            //    {
            //        Console.WriteLine("¡Despegue!");
            //    }

            //3.Estructuras Condicionales
            //Ejercicio 9: Número positivo, negativo o cero
            //Escribe un programa que solicite un número al usuario y determine si el número es positivo, negativo o cero
            //utilizando estructuras if, else if y else.

            //Console.WriteLine("Introduce un número.");
            //int Num = int.Parse(Console.ReadLine());

            //if (Num > 0)
            //{
            //    Console.WriteLine($"Tu número es {Num}. Es un número positivo.");
            //}

            //else if (Num < 0)
            //{
            //    Console.WriteLine($"Tu número es {Num}. Es un número negativo.");
            //}

            //else {
            //    Console.WriteLine("Tu número es 0.");
            //        }


            //Ejercicio 10: Calculadora básica
            //Crea un programa que implemente una calculadora básica. Solicita al usuario dos números y una operación(+, -, *, /).
            //Usa un switch para realizar la operación seleccionada.

            //Console.WriteLine("Introduce el primer número.");
            //int NumA = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Introduce el segundo número.");
            //int NumB = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Elige que operación quieres realizar: 1 para sumar, 2  para restar, 3 para multiplicar o 4 para dividir.");
            //int operation = Int32.Parse(Console.ReadLine());

            //switch (operation) {
            //    case 1:
            //        Console.WriteLine(NumA + NumB);
            //        break;
            //    case 2:
            //        Console.WriteLine(NumA - NumB);
            //        break;
            //    case 3:
            //        Console.WriteLine(NumA * NumB);
            //        break;
            //    case 4:
            //        Console.WriteLine(NumA / NumB);
            //        break;

            //}

            //Ejercicio 11: Clasificación por edad
            //Escribe un programa que pida al usuario su edad y clasifique si es un niño(0 - 12), un adolescente(13 - 17),
            //un adulto(18 - 64) o un anciano(65 en adelante) utilizando if, else if y else.

            //Console.WriteLine("Introduce una edad.");
            //int Edad = Int32.Parse(Console.ReadLine());

            //if (Edad <= 12 & Edad > 0)
            //{
            //    Console.WriteLine("La edad pertenece a un niño.");
            //}

            //else if (Edad >= 13 & Edad <= 17)
            //{
            //    Console.WriteLine("La edad pertenece a un adolescente.");
            //}

            //else if (Edad >= 18 & Edad <= 64)
            //{
            //    Console.WriteLine("La edad pertenece a un adulto.");
            //}

            //else if (Edad >= 65)
            //{
            //    Console.WriteLine("La edad pertenece a un anciano.");
            //}

            //else if (Edad < 0)
            //{
            //    Console.WriteLine("La edad no es válida.");
            //}

            //Bonus
            //Ejercicio 12: Número primo
            //Crea un programa que pida al usuario un número entero positivo y determine si es un número primo.
            //Utiliza un bucle for y estructuras condicionales para realizar la verificación.

            //Console.WriteLine("Introduce un número entero positivo");
            //int Num = int.Parse(Console.ReadLine());

            //if (Num <= 1)
            //{
            //    Console.WriteLine("El número no es primo");

            //}

            //for (int i = 2; i * i <= Num; i++) {
            //    if (Num % i == 0) { Console.WriteLine("El número no es primo"); }

            //    Console.WriteLine("El número es primo");

            //Ejercicio 13: Serie de Fibonacci
            //Escribe un programa que pida al usuario un número entero positivo y genere los primeros n términos de la serie de Fibonacci utilizando un bucle while o for.
            //            int suma = 0;
            //            int NumA = 0;
            //            int NumB = 1;

            //            Console.WriteLine("Escribe un número para generar la serie de Fibonacci.");
            //            int NumF = Int32.Parse(Console.ReadLine());

            //            for (int i = 1; i < NumF; i++) { 

            //            suma = NumA + NumB;
            //                NumA = NumB;
            //                NumB = suma;
            //;            Console.WriteLine(suma);
            //            }

            //StreamReader sr = new StreamReader("entrada.txt");
            //string contenido = sr.ReadToEnd();
            //sr.Close();

            //File.WriteAllText("text.txt", "Hola mundo");

            //File.AppendAllText("log.txt", "Resgistro añadido,");

            string mensaje = "Hola";
            Console.WriteLine($"El mensaje es: {mensaje}");

            string path = "archivo.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("Archivo encontrado.");
            } else { Console.WriteLine("Archivo no encontrado.");
            }

        }

    }
}




