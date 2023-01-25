using System;

namespace code_at_cs_treinando_generics
{
    public static class ComparadorGenerico<T>
    {
        public static bool Comparar(T valor1, T valor2)
        {
            return valor1.Equals(valor2);
        }
    }
}