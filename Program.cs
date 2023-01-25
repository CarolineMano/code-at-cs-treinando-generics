using System;
using System.Collections.Generic;
using System.Linq;

namespace code_at_cs_treinando_generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("**Comparador com sobrecarga de métodos**");
            Console.WriteLine(ComparadorSobrecarga.Comparar("a", "a"));
            Console.WriteLine(ComparadorSobrecarga.Comparar("a", "b"));
            Console.WriteLine(ComparadorSobrecarga.Comparar(1, 1));
            Console.WriteLine(ComparadorSobrecarga.Comparar(1, 2));
            Console.WriteLine(ComparadorSobrecarga.Comparar(0.1, 0.1));
            Console.WriteLine(ComparadorSobrecarga.Comparar(0.1, 0.2));

            Console.WriteLine("**Comparador com tipo genérico**");
            Console.WriteLine(ComparadorGenerico<string>.Comparar("a", "a"));
            Console.WriteLine(ComparadorGenerico<string>.Comparar("a", "b"));
            Console.WriteLine(ComparadorGenerico<int>.Comparar(1, 1));
            Console.WriteLine(ComparadorGenerico<int>.Comparar(1, 2));
            Console.WriteLine(ComparadorGenerico<double>.Comparar(0.1, 0.1));
            Console.WriteLine(ComparadorGenerico<double>.Comparar(0.1, 0.2));
        }
    }
}