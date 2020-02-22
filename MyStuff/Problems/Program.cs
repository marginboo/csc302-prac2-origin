using System;

namespace Problems
{
    public class Program
    {
        public static void Prefix (string input)
        {
            int ln = input.Length;
            int mum = input.Split(' ').Length;
            Console.WriteLine(ln.ToString(), ",",mum.ToString() , " ", input);

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
