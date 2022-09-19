using UnityEngine;

namespace Assets.Scripts.Features2.Delegates
{
    public class MulticastScript : MonoBehaviour
    {
        private delegate void MultiDelegate();
        private MultiDelegate myMultiDelegate;

        private void Start()
        {
            myMultiDelegate += PowerUp;
            myMultiDelegate += TurnRed;

            if (myMultiDelegate != null)
            {
                myMultiDelegate();
            }
        }

        private void PowerUp()
        {
            print("Orb is powering up!");
        }

        private void TurnRed()
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
