using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Features2.ListAndDictionaries
{
    public class SomeOtherClass : MonoBehaviour
    {
        private void Start()
        {
            Dictionary<string, BadGuy> badguys = new Dictionary<string, BadGuy>();

            BadGuy bg1 = new BadGuy("Harvey", 50);
            BadGuy bg2 = new BadGuy("Magneto", 100);

            badguys.Add("gangster", bg1);
            badguys.Add("mutant", bg2);

            BadGuy magneto = badguys["mutant"];

            BadGuy temp = null;

            if (badguys.TryGetValue("birds", out temp))
            {
                Debug.Log(temp.Name + " has " + temp.Power + " powers.");
            }
            else
            {
                Debug.Log("Mutant is not found!");
            }
        }
    }
}
