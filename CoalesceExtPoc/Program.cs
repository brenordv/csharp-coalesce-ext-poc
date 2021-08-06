using System;

namespace CoalesceExtPoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string foo = null;
            Console.WriteLine($"foo: {foo.Coalesce("bar")}");
            
            var bar = "bacon";
            Console.WriteLine($"bar: {bar.Coalesce("bar")}");

            var bar2 = "";
            Console.WriteLine($"bar2: {bar2.Coalesce("bar2")}");
            
            var bar3 = "    ";
            Console.WriteLine($"bar3: {bar3.Coalesce("bar3")}");
            
            int? a = null;
            Console.WriteLine($"a: {a.Coalesce(42)}");
            
            DateTime? b = null;
            Console.WriteLine($"b: {b.Coalesce(DateTime.MaxValue)}");
            
        }
    }

    public static class Ext
    {
        /// <summary>
        ///     Convenience method that checks if the object is null. If it is will return the specified default value.
        /// </summary>
        /// <param name="value">this value</param>
        /// <param name="defaultIfNull">default if this value is null</param>
        /// <typeparam name="T">inferred type.</typeparam>
        /// <returns>either the current value or the defaultIfNull</returns>
        public static T Coalesce<T>(this T value, T defaultIfNull)
        {
            if (value is string)
                return string.IsNullOrWhiteSpace(value.ToString()) ? defaultIfNull : value;
            
            return value == null ? defaultIfNull : value;
        }
    }
}