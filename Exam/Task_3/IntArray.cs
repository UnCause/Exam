using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class IntArray
    {
        public IntArray(int Length)
        {
            this._length = Length;
            _array = new int[Length];
        }
        private int _length;
        private protected int[] _array;

        public virtual int ArrayLength
        {
            get { return _length; }
        }

        public int this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }
    }
}
