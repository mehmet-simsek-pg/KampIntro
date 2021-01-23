using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary<K, V>
    {
        private K[] _keyArray;
        private V[] _valueArray;

        public MyDictionary()
        {
            _keyArray = new K[0];
            _valueArray = new V[0];
        }

        public void Add(K key, V value)
        {
            var _tempKeyArray = _keyArray;
            var _tempValueArray = _valueArray;

            _keyArray = new K[_keyArray.Length + 1];
            _valueArray = new V[_valueArray.Length + 1];

            for (int i = 0; i < _tempKeyArray.Length; i++)
            {
                _keyArray[i] = _tempKeyArray[i];
                _valueArray[i] = _tempValueArray[i];
            }

            _keyArray[_keyArray.Length - 1] = key;
            _valueArray[_valueArray.Length - 1] = value;
        }
    }
}