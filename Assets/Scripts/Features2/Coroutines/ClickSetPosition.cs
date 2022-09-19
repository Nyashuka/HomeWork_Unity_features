using UnityEngine;

namespace Assets.Scripts.Features2.Coroutines
{
    public class ClickSetPosition : MonoBehaviour
    {
        public PropertiesAndCoroutines coroutineScript;

        private void OnMouseDown()
        {
            Debug.Log("Clicked");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            Physics.Raycast(ray, out hit);

            if (hit.collider.gameObject == gameObject)
            {
                Vector3 newTarget = hit.point + new Vector3(0, 0.5f, 0);
                coroutineScript.Target = newTarget;
            }
        }
    }

}
