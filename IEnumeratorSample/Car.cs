using System;

namespace IEnumeratorSample
{
    //Легковой автомобиль
    public class Car : Automobile
    {
        public override void Display()
        {
            Console.WriteLine("Я " + base.Name);
        }

        public Car(string name) : base(name)
        {
        }
    }
}