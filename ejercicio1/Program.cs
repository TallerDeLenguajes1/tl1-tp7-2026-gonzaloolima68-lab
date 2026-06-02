using System;
using Espaciocalculadora;

namespace tp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora micalculadora = new Calculadora();

            string? opcion;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Resultado =" + micalculadora.resultado);
                Console.WriteLine("ingrese la operacion a realizar");
                Console.WriteLine("1-Sumar");
                Console.WriteLine("2-Restar");
                Console.WriteLine("3-Multiplicar");
                Console.WriteLine("4-Dividir");
                Console.WriteLine("5-Borrar");
                Console.WriteLine("0-Finalizar");

                opcion = Console.ReadLine();

                if (int.TryParse(opcion, out int opcion2))
                {
                    if (opcion2 >= 1 && opcion2 < 5)
                    {
                        string numtexto;
                        Console.WriteLine();
                        Console.WriteLine("Ingrese un numero");
                        numtexto = Console.ReadLine()!;
                        if (double.TryParse(numtexto, out double numero))
                        {
                            switch (opcion2)
                            {
                                case 1:
                                    micalculadora.sumar(numero);
                                    break;
                                case 2:
                                    micalculadora.restar(numero);
                                    break;
                                case 3:
                                    micalculadora.multiplicar(numero);
                                    break;
                                case 4:
                                    micalculadora.dividir(numero);
                                    break;
                            }
                        }
                    }
                    else if (opcion == "5")
                    {
                        micalculadora.limpiar();
                    }
                    else
                    {
                        Console.WriteLine("Finalizando operacion");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("numero invalida");
                    opcion = "0";
                }

            } while (opcion != "0");
        }

    }
}