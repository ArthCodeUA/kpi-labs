using System;

namespace lab_8
{
    public class AStack<T>
    {
        public delegate void StackHandler(StackHandlerArgs handlerArgs);

        public event StackHandler Except;

        private readonly int _size;
        private readonly T[] _array;
        private int _top;

        public AStack(int size)
        {
            _size = size;
            _top = 0;
            _array = new T[_size];
        }
        
        public int Size => _size;

        public int Count => _top;

        public T this[int index]
        {
            get => _array[index];
        }

        public bool IsFull()
        {
            return _top == _size;
        }

        public bool IsEmpty()
        {
            return _top == 0;
        }

        public void Push(T element)
        {
            if (IsFull())
            {
                Except?.Invoke(new StackHandlerArgs("StackOverflow exception happened!", this));
            }
            else
            {
                _array[_top++] = element;
            }
        }

        public T Peek()
        {
            return _array[_top - 1];
        }

        public T Pop()
        {
            if (!IsEmpty()) return _array[--_top];
            Except?.Invoke(new StackHandlerArgs("StackUnderflow exception happened!", this));
            return default;
        }
    }
}