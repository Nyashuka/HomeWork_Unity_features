using UnityEngine;

namespace Assets.Scripts.Features2.Quaternions
{
    public class LookAtScript : MonoBehaviour
    {
        [SerializeField] private Transform _target;

        private void Update()
        {
            Vector3 relativePos = _target.position - transform.position;
            transform.rotation = Quaternion.LookRotation(relativePos);
        }
    }
}
