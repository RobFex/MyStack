namespace StackProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> strStack = new MyStack<string>();
            strStack.Push("Hello world");
            Console.WriteLine(strStack.Peek());
            Console.WriteLine();

            MyStack<int> numStack = new MyStack<int>();
            numStack.Push(100);
            numStack.Push(200);
            numStack.Push(300);
            foreach (var n in numStack)
                Console.Write(String.Concat(n, " "));
            Console.ReadKey();
        }
    }
}