using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {
       public static int Add(int x, int y)
           
        {
            return (x + y);
         
        }

        public static decimal Add(decimal x, decimal y)
        {
            return (x + y);
        }

        public static string Add(bool isTrue, int x, int y)
        {

            if (isTrue && (x + y) != 1)
            {
                return $"You have {x + y} dollars.";
            }
            else if (isTrue && (x + y) == 1)
            {
                return $"You have {x + y} dollar.";
            }
            else
            {
                return $"{x + y}.";
            }
                
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 4));
            Console.WriteLine(Add(12.5m, 20.5m));
            Console.WriteLine(Add(false, 0, 0));



        }
    }
}
