using System;

namespace lab_3
{
    public class BoolArray
    {
        private bool[] _boolarray;
        private bool _logicsum;

        public bool Logicsum
        {
            get
            {
                bool result = false;
                for (int i = 0; i < _boolarray.Length; i++)
                {
                    if (i == 0) result = _boolarray[0];
                    result = result | _boolarray[i];
                }

                return result;
            }
        }

        public bool this[int index]
        {
            get
            {
                if (index < _boolarray.Length && index >= 0)
                {
                    return !_boolarray[index];
                }
                throw new IndexOutOfRangeException("Index out of bounds of array");
            }
            set
            {
                if (index < _boolarray.Length && index >= 0)
                {
                    _boolarray[index] = value;
                }
                throw new IndexOutOfRangeException("Index out of bounds of array");
            }
        }

        public BoolArray(int length)
        {
            _boolarray = new bool[length];
        }
    }
}