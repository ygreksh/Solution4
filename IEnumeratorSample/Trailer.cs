using System;

namespace IEnumeratorSample
{
    public class Trailer : Automobile

    {
        public Trailer(string name) : base(name)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Я " + base.Name);
        }
    }
}