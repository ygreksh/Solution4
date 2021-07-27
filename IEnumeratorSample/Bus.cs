using System;

namespace IEnumeratorSample
{
    //Автобус
    public class Bus : Automobile
    {
        public Bus(string name) : base(name)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Я " + base.Name);
        }
    }
}