using System;
using System.Collections.Generic;
using System.Text;

namespace Genericc_16._03._22
{
    class Store<T, U>
    {
        private T[] Languages;
        private U[] Dates;

        public Store()
        {
            Languages = new T[0];
            Dates = new U[0];
        }
        public void Add(T language, U date)
        {
            Array.Resize(ref Languages, Languages.Length + 1);
            Languages[Languages.Length - 1] = language;

            Array.Resize(ref Dates, Dates.Length + 1);
            Dates[Dates.Length - 1] = date;
        }

        public U[] GetDates()
        {
            return Dates;
        }
        public T[] GetLanguages()
        {
            return Languages;
        }

        internal IEnumerable<string> GetLanguage()
        {
            throw new NotImplementedException();
        }
    }
}
