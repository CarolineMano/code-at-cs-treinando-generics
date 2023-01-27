using System;
using System.Collections.Generic;

namespace code_at_cs_treinando_generics
{
    public static class ComparadorGenerico<T>
    {
        public static bool Comparar(T valor1, T valor2)
        {
            // Nos permite usar o Equals da classe que implementar IEquatable<T>
            return EqualityComparer<T>.Default.Equals(valor1, valor2);
        }
    }
}