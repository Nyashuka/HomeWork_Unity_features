using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Features1.Events
{
    public class EventManager : MonoBehaviour
    {
        public delegate void ClickAction();
        public static event ClickAction OnClicked;

        private void OnGUI()
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click"))
            {
                OnClicked?.Invoke();
            }
        }
    }
}
