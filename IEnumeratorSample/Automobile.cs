using System;

namespace IEnumeratorSample
{
    //Абстрактный класс Автомобиль
    public abstract class Automobile
    {
        public string Name {get; set; }

        public Automobile(string name)
        {
            Name = name;
        }
        public abstract void Display();
        /*
        public virtual void Display()
        {
            Console.WriteLine("Я абстрактный автомобиль. Меня тут быть не должно.");
        }
        */
    }
}