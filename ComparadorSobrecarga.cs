using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace code_at_cs_treinando_generics
{
    public static class ComparadorSobrecarga
    {
        public static bool Comparar(string valor1, string valor2)
        {
            return valor1.Equals(valor2);
        }

        public static bool Comparar(int valor1, int valor2)
        {
            return valor1.Equals(valor2);
        }

        public static bool Comparar(double valor1, double valor2)
        {
            return valor1.Equals(valor2);
        }
    }
}