using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Genericc_16._03._22
{
    class Notebook: ICollection
    {
        public int Id;
        public string Model;

        public static int Count = 1;

        int ICollection.Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public Notebook(string model)
        {
            Id = Count;
            Model = model;
        }

        public override string ToString()
        {
            return $"Model: {Model}";
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
