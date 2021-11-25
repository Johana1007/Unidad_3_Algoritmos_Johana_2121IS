using System;
namespace Hola
{

    class Program
    {
        static void Main(string[] args)
        {

            String opcion = "";
            while (opcion == "si" || opcion == "si") ;

            int Valor1 = 0;
            int Valor2 = 0;
            int Total = 0;

            Console.WriteLine("Elija su operacion a realizar");
            Console.WriteLine("1.- Para sumar");
            Console.WriteLine("2.- Para restar");
            Console.WriteLine("3.- Para multiplicar");
            Console.WriteLine("4.- Para dividir");
            opcion = Console.ReadLine();

            String eleccion = Convert.ToString(opcion);

            Console.Write("Ingrese su primer valor");
            Valor1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su segundo valor");
            Valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (eleccion)
            {
                case "1":
                    Console.WriteLine("El resultado de la suma es:");
                    Total = Valor1 + Valor2;
                    Console.WriteLine("El resultado de tu operacion es: " + Total);
                    break;

                case "2":
                    Console.WriteLine("El resultado de la resta es:");
                    Total = Valor1 - Valor2;
                    Console.WriteLine("El resultado de tu operacion es: " + Total);
                    break;

                case "3":
                    Console.WriteLine("El resultado de la divicion es:");
                    Total = Valor1 / Valor2;
                    Console.WriteLine("El resultado de tu operacion es: " + Total);
                    break;

                case "4":
                    Console.WriteLine("El resultado de la multiplicacion es:");
                    Total = Valor1 * Valor2;
                    Console.WriteLine("El resultado de tu operacion es: " + Total);
                    break;
            }
        }
    }
}