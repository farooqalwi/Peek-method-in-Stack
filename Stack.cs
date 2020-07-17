using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peek_method_in_Stack
{
    class Stack
    {
        ArrayList stack;

        public Stack()
        {
            stack = new ArrayList();
        }

        public void Push(object element)
        {
            stack.Add(element);
        }

        public object Pop()
        {
            object element = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return element;
        }

        public object Peek()
        {
            object element = stack[stack.Count - 1];
            return element;
        }

        public void Print()
        {
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}
