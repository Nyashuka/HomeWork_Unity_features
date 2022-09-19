using System;
namespace Assets.Scripts.Features2.ListAndDictionaries
{
    public class BadGuy : IComparable<BadGuy>
    {
        public string Name { get; private set; }
        public int Power { get; private set; }

        public BadGuy(string newName, int newPower)
        {
            Name = newName;
            Power = newPower;
        }
 
        public int CompareTo(BadGuy other)
        {
            if (other == null)
            {
                return 1;
            }

            return Power - other.Power;
        }
    }
}
