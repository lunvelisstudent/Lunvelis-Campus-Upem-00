using System;

class Program
{
    static void Main()
    {
        char moneda = '$';

        Console.WriteLine("===== REPORTES DE LA TIENDITA =====");
        Console.WriteLine("1. Tabla de precios por cantidad");
        Console.WriteLine("2. Ventas de la semana");
        Console.WriteLine("3. Total de piezas en promoción");
        Console.WriteLine("4. Salir");
        Console.Write("Elige una opción: ");
        int opcion = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        switch (opcion)
        {
            case 1:
                Console.Write("Precio unitario: ");
                double precio = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                for (int i = 1; i <= 10; i++)
                {
                    double totalFila = precio * i;

                    if (i >= 6)
                    {
                        totalFila = totalFila * 0.90;
                        Console.WriteLine(i + " pieza(s) = " + moneda + totalFila.ToString("F2") + " (con descuento)");
                    }
                    else
                    {
                        Console.WriteLine(i + " pieza(s) = " + moneda + totalFila.ToString("F2"));
                    }
                }
                break;

            case 2:
                double totalSemana = 0;
                double ventaMayor = 0;
                int diaMayor = 0;
                int diasMas1000 = 0;

                for (int dia = 1; dia <= 7; dia++)
                {
                    Console.Write("Venta del día " + dia + ": ");
                    double venta = Convert.ToDouble(Console.ReadLine());

                    totalSemana = totalSemana + venta;

                    if (venta > ventaMayor)
                    {
                        ventaMayor = venta;
                        diaMayor = dia;
                    }

                    if (venta > 1000)
                    {
                        diasMas1000++;
                    }
                }

                double promedio = totalSemana / 7;

                Console.WriteLine();
                Console.WriteLine("Total: " + moneda + totalSemana.ToString("F2"));
                Console.WriteLine("Promedio: " + moneda + promedio.ToString("F2"));
                Console.WriteLine("Venta más alta: " + moneda + ventaMayor.ToString("F2") + " el día " + diaMayor);
                Console.WriteLine("Días con venta mayor a " + moneda + "1000: " + diasMas1000);
                break;

            case 3:
                Console.Write("¿Cuántos días dura la promoción? (1 a 20): ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (n < 1 || n > 20)
                {
                    Console.WriteLine("Cantidad inválida");
                }
                else
                {
                    int totalPiezas = 0;
                    long producto = 1;
                    int pares = 0;
                    int impares = 0;

                    for (int dia = 1; dia <= n; dia++)
                    {
                        Console.WriteLine("Día " + dia + ": se regalaron " + dia + " pieza(s)");

                        totalPiezas = totalPiezas + dia;
                        producto = producto * dia;

                        bool esPar = dia % 2 == 0;

                        if (esPar)
                        {
                            pares++;
                        }
                        else
                        {
                            impares++;
                        }
                    }

                    Console.WriteLine("Total de piezas regaladas: " + totalPiezas);
                    Console.WriteLine("Producto de los días: " + producto);
                    Console.WriteLine("Días pares: " + pares);
                    Console.WriteLine("Días impares: " + impares);
                }
                break;

            case 4:
                Console.WriteLine("Gracias por usar los reportes de la tiendita");
                break;

            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
}
