// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;


namespace StackandQueue
{
    public class Program
    {

        public static void Main(string[] args)
        {
            
                Mystack<int> stack = new Mystack<int>();
                stack.Push(70);
                stack.Push(37);
                stack.Push(56);
                stack.pop();
                stack.Peek();
            }
        }
    }
        
