// See https://aka.ms/new-console-template for more information
using static StackandQueue.MyStack;

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
        }

    }
}
