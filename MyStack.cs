namespace StackProject
{
    public class MyStack<T>
    {
            private T[] _stack;
            public int Elements { get; private set; }
            public int Capacity
            {
                get
                {
                    return _stack.Length;
                }
            }
            public MyStack()
            {
                const int defCapacity = 4;
                _stack = new T[defCapacity];
            }
            public MyStack(int capacity)
            {
                _stack = new T[capacity];
            }
            public void Push(T item)
            {
                if (Elements >= Capacity)
                {
                    T[] tempStack = new T[Elements * 2];
                    Array.Copy(_stack, tempStack, Elements);
                    _stack = tempStack;
                }
                _stack[Elements++] = item;
            }
            public void Pop()
            {
                if (Elements == 0)
                {
                    throw new InvalidOperationException();
                }
                _stack[--Elements] = default(T); // the same as null
            }
            public object Peek()
            {
                if (Elements == 0)
                {
                    throw new InvalidOperationException();
                }
                return _stack[Elements - 1]; // not decrement
        }
    }
}
