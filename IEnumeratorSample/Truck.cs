using System;

namespace IEnumeratorSample
{
    //Грузовой авомобиль
    public class Truck : Automobile
    {
        public Truck(string name) : base(name)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Я " + base.Name);
        }
    }
}