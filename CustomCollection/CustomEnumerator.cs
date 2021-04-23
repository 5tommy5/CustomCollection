using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection
{
    class CustomEnumerator<T> : IEnumerator<T> 
    {
        private T[] arr;
        private int Cursor;
        public CustomEnumerator(T[] arr)
        {
            this.arr = arr;
            this.Cursor = -1;
        }
        public T Current => throw new NotImplementedException();

        object IEnumerator.Current
        {
            get
            {
                if ((Cursor < 0) || (Cursor == arr.Length))
                    throw new InvalidOperationException();
                return arr[Cursor];
            }
        } 

        public void Dispose()
        {
            this.arr = null;
            this.Cursor = 0;
        }

        public bool MoveNext()
        {
            if (Cursor < arr.Length)
                Cursor++;

            return (!(Cursor == arr.Length));
        }

        public void Reset()
        {
            Cursor = -1;
        }
    }
}
