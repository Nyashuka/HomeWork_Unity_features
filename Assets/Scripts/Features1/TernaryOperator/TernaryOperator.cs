using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Features1.TernaryOperator
{
    public class TernaryOperator : MonoBehaviour
    {
        private void Start()
        {
            int health = 10;

            Debug.Log(health > 0 ? "Player is Alive" : "Player is Dead");
        }
    }
}

