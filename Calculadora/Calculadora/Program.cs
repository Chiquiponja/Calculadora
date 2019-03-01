using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Ingrese el numero de la operacion que desea realizar");
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar ");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine(" ");

            int operacion = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Calcular(operacion);
        }

        private static void Calcular(int operacion)
        {
            int numero1 = 0;
            int numero2 = 0;
            double resultado = 0;
            double Sumar = 0;
            double restar = 0;
            double division = 0;
            if (operacion == 1 || operacion == 2 || operacion == 3 || operacion == 4)
            {
                Console.Clear();
                if (operacion == 1)
                {
                    Console.WriteLine("SUMAR");
                }
                else if (operacion == 2)
                {
                    Console.WriteLine("RESTAR");
                }
                else if (operacion == 3)
                {
                    Console.WriteLine("MULTIPLICAR");
                }
                else if (operacion == 4)
                {
                    Console.WriteLine("DIVIDIR");
                }

                Console.Write("Ingrese el primer numero: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                numero2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                if (operacion == 1)
                {
                    resultado = numero1 + numero2;
                    Console.WriteLine("Resultado  = {2} ", numero1, numero2, resultado);
                }
                else if (operacion == 2)
                {
                    if (numero1 >= numero2)
                    {
                        for (int k = numero2; k < numero1; k++)
                        { //con k < cantidad te aseguras que no sobrepase de CINCO veces 
                          //esta linea hace lo que decis en "5+5+5+5+5" y va a terminar en 25 
                            restar++;
                        }
                        Console.WriteLine("Resultado  = {2}", numero1, numero2, restar);
                    }
                    else
                    {
                        for (int k = numero1; k < numero2; k++)
                        { //con k < cantidad te aseguras que no sobrepase de CINCO veces 
                          //esta linea hace lo que decis en "5+5+5+5+5" y va a terminar en 25 
                            restar++;
                        }
                        Console.WriteLine("Resultado  = - {2}", numero1, numero2, restar);
                    }


                }
                else if (operacion == 3)
                {
                    for (int k = 0; k < numero2; ++k)
                    { //con k < cantidad te aseguras que no sobrepase de CINCO veces 
                        Sumar += numero1; //esta linea hace lo que decis en "5+5+5+5+5" y va a terminar en 25 
                    }

                    Console.WriteLine("Resultado =  {2} ", numero1, numero2, Sumar);
                }





                else if (operacion == 4)
                {
                    if (numero1 >= numero2)
                    {

                        for (int i = 0; i < numero1; i = i + numero2)
                        { //con k < cantidad te aseguras que no sobrepase de CINCO veces 

                            division++;//esta linea hace lo que decis en "5+5+5+5+5" y va a terminar en 25 
                        }

                        Console.WriteLine("Resultado  {0}", division);
                    }


                    //else
                    //    {
                    //        for (int k = numero2; k < numero1; k++)
                    //        { //con k < cantidad te aseguras que no sobrepase de CINCO veces 
                    //          //esta linea hace lo que decis en "5+5+5+5+5" y va a terminar en 25 
                    //            division++;
                    //        }
                    //        Console.WriteLine("Resultado = - {2} ", numero1, numero2, division);
                    //    }
                    //}
                }

                else
                {
                    Console.WriteLine("No se ha seleccionado una de las operaciones probables");
                }

                //Console.WriteLine(restar); //muestra Suma, que es la sumaSucesiva 
                //Console.ReadKey(true); //esta linea es para que no se cierre la aplicacion y podas ver el resultado


                //Console.WriteLine(Sumar); //muestra Suma, que es la sumaSucesiva 
                //Console.ReadKey(true); //esta linea es para que no se cierre la aplicacion y podas ver el resultado


                //Console.WriteLine(division); //muestra Suma, que es la sumaSucesiva 
                //Console.ReadKey(true); //esta linea es para que no se cierre la aplicacion y podas ver el resultado

                Console.ReadKey();


            }
        }
    }
}