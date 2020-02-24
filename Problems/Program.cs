using System;

namespace Problems
{
    class Program
    {
        public static void Prefix (string input)
        {
            int ln = input.Length;
            string[] mum = input.Split();
            int sis = mum.Length;
            Console.WriteLine(ln.ToString(), ",",sis.ToString() , " ", input);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter something");
            string man = Console.ReadLine();
            Program mn = new Program();
            Prefix(man);
            
        }
    }
}
