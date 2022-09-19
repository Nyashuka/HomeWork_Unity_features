using UnityEngine;

namespace Assets.Scripts.Features1.Events
{
    public class TeleportScript : MonoBehaviour
    {
        private void OnEnable()
        {
            EventManager.OnClicked += Teleport;
        }

        private void OnDisable()
        {
            EventManager.OnClicked -= Teleport;
        }

        public void Teleport()
        {
            Vector3 pos = transform.position;
            pos.y = Random.Range(1.0f, 3.0f);
            transform.position = pos;
        }
    }
}
