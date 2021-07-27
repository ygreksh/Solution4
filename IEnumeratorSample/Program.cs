using System;

namespace IEnumeratorSample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Обычный массив
            Automobile[] autopark = new Automobile[4]
            {
                new Car("Легковой автомобиль"),
                new Truck("Грузовой автомобиль"),
                new Bus("Автобус"),
                new Trailer("Прицеп")
            };

            //Массмв
            Console.WriteLine("Вывод из массива");
            foreach (var item in autopark)
            {
                item.Display();
            }

            
            //IEnumerator
            Console.WriteLine("Вывод из коллекции");
            Automobiles EnumeratorAutopark = new Automobiles(autopark);
            foreach (var item in EnumeratorAutopark)
            {
                //item.Display();
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Вывод из коллекции с помощью while()");
            var iter = EnumeratorAutopark.GetEnumerator();
            while (iter.MoveNext())
            {
                iter.Current.Display();
            }
        }
    }
}