using System;

namespace lab_8
{
    static class Program
    {
        static void Main(string[] args)
        {
            /* Task 1 */
            
            AStack<int> stack = new AStack<int>(3);
            stack.Except += StackOverflowHandler;
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            PrintStack(stack);
            stack.Push(4);
            
            /* Task 2 */

            ATask.LineOperation charSearch = ATask.GetFirstCharIndex;
            Console.WriteLine(charSearch('s', "Wassup"));
        }
        
        private static void StackOverflowHandler(StackHandlerArgs handlerArgs)
        {
            Console.WriteLine(handlerArgs.Message);
        }

        private static void PrintStack<T>(AStack<T> stack)
        {
            for(int i = 0; i < stack.Count; i++)
            {
                Console.Write(stack[i] + ( i != stack.Count - 1 ? " -> " : ""));
            }
            Console.WriteLine();
        }
    }
}