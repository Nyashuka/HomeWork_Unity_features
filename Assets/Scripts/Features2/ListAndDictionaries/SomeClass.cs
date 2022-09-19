using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Features2.ListAndDictionaries
{
    public class SomeClass : MonoBehaviour
    {
        private void Start()
        {
            List<BadGuy> badguys = new List<BadGuy>();

            badguys.Add(new BadGuy("Harvey", 50));
            badguys.Add(new BadGuy("Magneto", 100));
            badguys.Add(new BadGuy("Pip", 5));

            badguys.Sort();

            foreach (BadGuy guy in badguys)
            {
                print(guy.Name + " " + guy.Power);
            }

            badguys.Clear();
        }
    }
}
