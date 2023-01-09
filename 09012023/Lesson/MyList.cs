using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class MyList<T>
    {
        public MyList(int size = 0)
        {
            _arr = new T[size];
        }
        T[] _arr;

        public void Add(T value)
        {
            System.Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }

        public T GetValue(int index)
        {
            return _arr[index];
        }

        public T[] Array => _arr;

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _arr.Length)
                throw new IndexOutOfRangeException();

            for (int i = index; i < _arr.Length - 1; i++)
            {
                var swap = _arr[i];
                _arr[i] = _arr[i + 1];
                _arr[i + 1] = swap;
            }


            System.Array.Resize(ref _arr, _arr.Length - 1);
        }

        public void Remove(T value)
        {
            var index = System.Array.IndexOf(_arr, value);

            RemoveAt(index);
        }
    }
}
