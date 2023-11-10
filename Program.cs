using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method3
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Stack<char> stack = new Stack<char>(50);
            string str = "";
            Console.Write(": ");
            str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(') stack.Push(str[i]);
                else if (str[i] == ')')
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("Nope");
                        Console.WriteLine($"Extra ')' in position{i + 1}");
                        return 1;
                    }
                    stack.Pop();
                }
            }
            if (stack.Count != 0)
            {
                Console.WriteLine("Nope");
                Console.WriteLine($"Extra '(' in quantity: {stack.Count}");
            }
            else Console.WriteLine("Yep");
            return 0;
        }
    }
}
