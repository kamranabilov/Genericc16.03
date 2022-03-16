using System;
using System.Collections;

namespace Genericc_16._03._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple<string> apple = new Apple<string>("Red");
            Console.WriteLine(apple.Color);

            PineApple<string> pineapple = new PineApple<string>("Water");
            Console.WriteLine(pineapple.Juice);

            Lemon<int> lemon = new Lemon<int>(5);
            Console.WriteLine(5);


            BasketList basketList = new BasketList();
            basketList.Add("Red");
            basketList.Add("Water");
            basketList.Add("5");
            Console.WriteLine("Count: \n" + basketList.Count);
            foreach (string word in basketList.GetArray())
            {
                Console.WriteLine(word);
            }

            Store<string, int> store = new Store<string, int>();
            store.Add("Lava", 1995);
            store.Add("python", 1990);
            store.Add("c#", 2001);

            foreach (string item in Store.GetLanguage())
            {
                Console.WriteLine(item);
            }

            foreach (int item in store.GetDates())
            {
                Console.WriteLine(item);
            }
            Store<Notebook, ICollection> store1 = new Store<Notebook, ICollection>();
        }
    }
}
