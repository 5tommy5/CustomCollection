using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection
{


    public class CustomCollectionS<T> : IEnumerable<T> 
    {
        private T[] arr;
        private T max;

        private Type type;

        public CustomCollectionS()
        {
            T max = default(T);
            this.arr = new T[0];
            this.type = max.GetType();

        }
        public T this[int index] { get => index>=0 && index<this.arr.Length? this.arr[index]:default; set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            Array.Resize(ref this.arr, this.arr.Length + 1);
            this.arr[this.arr.Length - 1] = item;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return new CustomEnumerator<T>(this.arr);
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();

        }

        public void Insert(int index, T item)
        {
            T[] arr1 = new T[this.arr.Length + 1];
            bool flag = false;

            for (var i = 0; i < this.arr.Length; i++)
            {
                if (i == index && flag == false)
                {
                    arr1[index] = item;
                    i -= 1;
                    flag = true;
                    continue;
                }
                arr1[i + (flag?1:0)] = arr[i ];
            }
            if (index == this.arr.Length)
            {
                arr1[index] = item;
            }
            this.arr = arr1;
        }

        public bool Remove(T item)
        {
            T[] arr1 = new T[this.arr.Length - 1];
            bool flag = false;
            for(var i = 0; i < this.arr.Length; i++)
            {
                if (this.arr[i].Equals(item) && !flag)
                {
                    flag = true;
                    continue;
                }
                arr1[i - (flag ? 1 : 0)] = this.arr[i];
            }
            this.arr = arr1;
            return flag;
        }

        public void RemoveAt(int index)
        {
            if(index >= this.arr.Length || index<0)
            {
                return;
            }
            T[] arr1 = new T[this.arr.Length - 1];
            bool flag = false;
            for(var i = 0; i< arr.Length; i++)
            {
                if(i == index && !flag)
                {
                    flag = true;
                    continue;
                }

                arr1[i - (flag ? 1 : 0)] = this.arr[i];
            }
            this.arr = arr1;
        }

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return new CustomEnumerator<T>(this.arr);
        //}

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new CustomEnumerator<T>(this.arr);
        }
    }
}
