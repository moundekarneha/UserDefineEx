using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefineEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 1 no.");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2 no.");
                int b = int.Parse(Console.ReadLine());

                if(b%2!=0)
                {
                    //throw new UserDefineException();
                    UserDefineException u = new UserDefineException();
                    throw u;
                }
                int c = a / b;
                Console.WriteLine("Result = " + c);


            }
            catch (UserDefineException e)
            {
                Console.WriteLine(e.Message);
             
            }
            Console.ReadLine();
        }
    }
}
