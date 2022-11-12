namespace StackProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> strStack = new MyStack<string>();
            strStack.Push("Hello world");
            Console.WriteLine(strStack.Peek());
            Console.ReadKey();
        }
    }
}