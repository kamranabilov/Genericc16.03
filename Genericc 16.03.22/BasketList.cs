using System;
using System.Collections.Generic;
using System.Text;

namespace Genericc_16._03._22
{
    class BasketList<T>
    {
        private string[] arr;

        public int Count
        {
            get
            {
                return arr.Length;
            }
        }

        public BasketList()
        {
            arr = new string[0];
        }

        public void Add(string word)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = word;
        }

        public string[] GetArray()
        {
            return arr;
        }
    }
}
