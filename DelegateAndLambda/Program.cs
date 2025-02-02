namespace DelegateAndLambda
{
    internal static class Program
    {
        ////case 1: this code use delegate 
        //public delegate bool CheckIntDlg(int n);
        //public static bool CheckIntLessThan20(int n)
        //{
        //    return n < 20;
        //}
        //static IEnumerable<int> Check(List<int> ints, CheckIntDlg dlg)
        //{
        //    foreach (var n in ints)
        //    {
        //        if (dlg(n)) yield return n;
        //    }
        //}
        //-----------------------------------------------------------------------------------
        ////case 2: same code as above block but use Predicate instead of delegate and use another function as parameter
        //public static bool CheckIntLessThan20(int n)
        //{
        //    return n < 20;
        //}
        //static IEnumerable<int> Check(List<int> ints, Predicate<int> predicate)
        //{
        //    foreach (var n in ints)
        //    {
        //        if (predicate(n)) yield return n;
        //    }
        //}
        //-----------------------------------------------------------------------------------
        //same code as above block but use Predicate instead of delegate
        static IEnumerable<int> Check(this List<int> ints, Predicate<int> predicate)
        {
            foreach (var n in ints)
            {
                if (predicate(n)) yield return n;
            }
        }

        static void Main(string[] args)
        {
            var a = new List<int>() { 1, 2, 3, 4, 5, 14, 52 };

            ////fucntion for case 1 and 2 (delegate)
            //var b = Check(a, CheckIntLessThan20);

            ////function for case 3 (anonymous function)
            //var b = Check(a, (int n) => { return n < 20; });

            //function for case 3 (but with lamda expression)
            var b = Check(a, n => n < 20);

            foreach (var item in b)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
