using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndLambda
{
    public static class MyLinq
    {
        public static IEnumerable<T> CheckStudentAgeLessThan20<T>(this IEnumerable<T> source, Predicate<T> predicate) where T: class
        {
            foreach (var item in source)
            {
                if (predicate(item)) yield return item;
            }
        }
    }
}
