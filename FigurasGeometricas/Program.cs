using FigurasGeometricas;
using System;
using System.Collections.Generic;

namespace FigurasGeometricas 
{

    class Program
    {
        static void Main(string[] args)
        {
            List<FiguraGeometrica> figuras = new List<FiguraGeometrica>();

            while (true)
            {

                Console.WriteLine("1. Crear Cuadrado");
                Console.WriteLine("2. Crear Rectángulo");
                Console.WriteLine("3. Crear Triángulo");
                Console.WriteLine("4. Crear Círculo");
                Console.WriteLine("5. Mostrar Información");
                Console.WriteLine("6. Salir");

                Console.Write("Ingrese la opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el lado del cuadrado: ");
                        double ladoCuadrado = Convert.ToDouble(Console.ReadLine());
                        figuras.Add(new Cuadrado(ladoCuadrado));
                        break;
                    case 2:
                        Console.Write("Ingrese la base del rectángulo: ");
                        double baseRectangulo = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la altura del rectángulo: ");
                        double alturaRectangulo = Convert.ToDouble(Console.ReadLine());
                        figuras.Add(new Rectangulo(baseRectangulo, alturaRectangulo));
                        break;
                    case 3:
                        Console.Write("Ingrese el lado 1 del triángulo: ");
                        double lado1Triangulo = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el lado 2 del triángulo: ");
                        double lado2Triangulo = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el lado 3 del triángulo: ");
                        double lado3Triangulo = Convert.ToDouble(Console.ReadLine());
                        figuras.Add(new Triangulo(lado1Triangulo, lado2Triangulo, lado3Triangulo));
                        break;
                    case 4:
                        Console.Write("Ingrese el radio del círculo: ");
                        double radioCirculo = Convert.ToDouble(Console.ReadLine());
                        figuras.Add(new Circulo(radioCirculo));
                        break;
                    case 5:
                        Console.WriteLine("Información de las figuras:");
                        foreach (var figura in figuras)
                        {
                            if (figura is IFiguraGeometrica figuraGeometrica)
                            {
                                figuraGeometrica.MostrarInformacion();
                                figuraGeometrica.DibujarFigura();
                                Console.WriteLine($"Área: {figura.CalcularArea()}, Perímetro: {figura.CalcularPerimetro()}");
                            }
                        }
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida.");
                        break;
                }
            }
        }
    }

}