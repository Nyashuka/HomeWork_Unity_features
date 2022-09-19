using UnityEngine;

namespace Assets.Scripts.Features2.Quaternions
{
    public class MotionScript : MonoBehaviour
    {
        [SerializeField] private float _speed = 3f;

        private void Update()
        {
            transform.Translate(-Input.GetAxis("Horizontal") * _speed * Time.deltaTime, 0, 0);
        }
    }
}
