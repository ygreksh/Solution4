using System.Collections;
using System.Collections.Generic;

namespace IEnumeratorSample
{
    public class Automobiles : IEnumerable<Automobile>

    {
        private List<Automobile> internalList;

        public Automobiles(Automobile[] autopark)
        {
            internalList = new List<Automobile>(autopark);
        }


        public IEnumerator<Automobile> GetEnumerator()
        {
            return internalList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}