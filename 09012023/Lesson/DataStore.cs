using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class DataStore<TKey,TValue> 
    {
        public DataStore(int size = 0)
        {
            _keys = new TKey[size];
            _values = new TValue[size];
        }
        TKey[] _keys;
        TValue[] _values;

        public void Add(TKey key,TValue value)
        {
            if (HasKey(key))
                throw new FormatException();

            Array.Resize(ref _keys, _keys.Length + 1);
            _keys[_keys.Length - 1] = key;


            Array.Resize(ref _values, _values.Length + 1);
            _values[_values.Length - 1] = value;
        }

        public bool HasKey(TKey key)
        {
            var index = Array.IndexOf(_keys, key);

            return index != -1;
        }

        public TValue[] Values => _values;

        public TValue GetValue(TKey key)
        {
            var index = Array.IndexOf(_keys, key);

            if (index < 0) throw new IndexOutOfRangeException();

            return _values[index];
        }
    }
}
