using UnityEngine;

namespace Scripts.Features1.Attributes
{
    public class SpinScript : MonoBehaviour
    {
        [SerializeField] [Range(-100, 100)] private int _speed = 0;

        private void Update()
        {
            transform.Rotate(new Vector3(0, _speed * Time.deltaTime, 0));
        }
    }
}