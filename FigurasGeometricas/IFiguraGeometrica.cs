using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{

    // Definición de la clase abstracta FiguraGeometrica
    public abstract class FiguraGeometrica
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }

    // Definición de la interfaz IFiguraGeometrica
    public interface IFiguraGeometrica
    {
        void MostrarInformacion();
        void DibujarFigura();
    }

    // Clase Cuadrado
    public class Cuadrado : FiguraGeometrica, IFiguraGeometrica
    {
        private double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public override double CalcularArea()
        {
            return lado * lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * lado;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Cuadrado - Lado: {lado}");
        }

        public void DibujarFigura()
        {
            Console.WriteLine("Dibujando un cuadrado...");
        }
    }

    // Clase Rectángulo
    public class Rectangulo : FiguraGeometrica, IFiguraGeometrica
    {
        private double baseRectangulo;
        private double alturaRectangulo;

        public Rectangulo(double baseRectangulo, double alturaRectangulo)
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;
        }

        public override double CalcularArea()
        {
            return baseRectangulo * alturaRectangulo;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (baseRectangulo + alturaRectangulo);
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Rectángulo - Base: {baseRectangulo}, Altura: {alturaRectangulo}");
        }

        public void DibujarFigura()
        {
            Console.WriteLine("Dibujando un rectángulo...");
        }
    }

    // Clase Triángulo
    public class Triangulo : FiguraGeometrica, IFiguraGeometrica
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public override double CalcularArea()
        {
            // Fórmula de Herón para el área de un triángulo
            double s = (lado1 + lado2 + lado3) / 2;
            return Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
        }

        public override double CalcularPerimetro()
        {
            return lado1 + lado2 + lado3;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Triángulo - Lado1: {lado1}, Lado2: {lado2}, Lado3: {lado3}");
        }

        public void DibujarFigura()
        {
            Console.WriteLine("Dibujando un triángulo...");
        }
    }

    // Clase Círculo
    public class Circulo : FiguraGeometrica, IFiguraGeometrica
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Círculo - Radio: {radio}");
        }

        public void DibujarFigura()
        {
            Console.WriteLine("Dibujando un círculo...");
        }
    }
}

