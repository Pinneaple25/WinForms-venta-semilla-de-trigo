namespace venta_semilla_de_trigo.Utilities
{
    public static class LinqExtensions
    {
        public static Func<T, bool> And<T>(this Func<T, bool> expr1, Func<T, bool> expr2) =>
            v => expr1(v) && expr2(v);
    }
}
