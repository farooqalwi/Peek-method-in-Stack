using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peek_method_in_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            stack.Print();

            Console.WriteLine("After Peek");

            object num = stack.Peek();
            stack.Print();

            Console.Write("Peek value: ");
            Console.WriteLine(num);

        }
    }
}
