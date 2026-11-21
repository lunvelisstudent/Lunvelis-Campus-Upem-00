using System;

class Program
{
    static void Main()
    {
        // Ejercicio 1: Numero mayor a 100
        Console.WriteLine("Ejercicio 1: Numero mayor a 100");
        Console.Write("Ingresa un numero: ");
        int numero1 = int.Parse(Console.ReadLine());

        if (numero1 > 100)
        {
            Console.WriteLine("El numero es mayor que 100");
        }

        // Ejercicio 2: Envio gratis
        Console.WriteLine("Ejercicio 2: Envio gratis");
        Console.Write("Ingresa el monto de compra: ");
        double compra = double.Parse(Console.ReadLine());

        if (compra >= 500)
        {
            Console.WriteLine("Tienes envio gratis");
        }

        Console.WriteLine("Total: " + compra);

        // Ejercicio 3: Multiplo de 5
        Console.WriteLine("Ejercicio 3: Multiplo de 5");
        Console.Write("Ingresa un numero: ");
        int numero3 = int.Parse(Console.ReadLine());

        if (numero3 % 5 == 0)
        {
            Console.WriteLine("El numero es multiplo de 5");
        }

        // Ejercicio 4: Mayor de dos numeros
        Console.WriteLine("Ejercicio 4: Mayor de dos numeros");
        Console.Write("Ingresa el primer numero: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo numero: ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("El mayor es: " + a);
        }
        else
        {
            Console.WriteLine("El mayor es: " + b);
        }

        // Ejercicio 5: Positivo o negativo
        Console.WriteLine("Ejercicio 5: Positivo o negativo");
        Console.Write("Ingresa un numero: ");
        int numero5 = int.Parse(Console.ReadLine());

        if (numero5 >= 0)
        {
            Console.WriteLine("El numero es positivo o cero");
        }
        else
        {
            Console.WriteLine("El numero es negativo");
        }

        // Ejercicio 6: Saldo suficiente
        Console.WriteLine("Ejercicio 6: Saldo suficiente");
        Console.Write("Ingresa tu saldo: ");
        double saldo = double.Parse(Console.ReadLine());

        Console.Write("Ingresa el monto de compra: ");
        double monto = double.Parse(Console.ReadLine());

        if (saldo >= monto)
        {
            Console.WriteLine("Compra realizada");
            double restante = saldo - monto;
            Console.WriteLine("Saldo restante: " + restante);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente");
        }

        // Ejercicio 7: Numero par o impar
        Console.WriteLine("Ejercicio 7: Numero par o impar");
        Console.Write("Ingresa un numero: ");
        int numero7 = int.Parse(Console.ReadLine());

        if (numero7 % 2 == 0)
        {
            Console.WriteLine("El numero es par");
        }
        else
        {
            Console.WriteLine("El numero es impar");
        }

        // Ejercicio 8: Aprobado o reprobado
        Console.WriteLine("Ejercicio 8: Aprobado o reprobado");
        Console.Write("Ingresa tu calificacion: ");
        double calificacion = double.Parse(Console.ReadLine());

        if (calificacion >= 6)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }

        // Ejercicio 9: Contrasena correcta
        Console.WriteLine("Ejercicio 9: Contrasena correcta");
        Console.Write("Ingresa la contrasena: ");
        string clave = Console.ReadLine();

        if (clave == "upem2026")
        {
            Console.WriteLine("Acceso concedido");
        }
        else
        {
            Console.WriteLine("Acceso denegado");
        }
    }
}
