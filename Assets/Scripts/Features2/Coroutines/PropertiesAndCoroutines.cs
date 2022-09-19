using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Features2.Coroutines
{
    public class PropertiesAndCoroutines : MonoBehaviour
    {
        [SerializeField] private float _smoothing = 7f;

        public Vector3 Target
        {
            get { return _target; }
            set
            {
                _target = value;

                StopCoroutine("Movement");
                StartCoroutine("Movement", _target);
            }
        }


        private Vector3 _target;


        private IEnumerator Movement(Vector3 target)
        {
            while (Vector3.Distance(transform.position, target) > 0.05f)
            {
                transform.position = Vector3.Lerp(transform.position, target, _smoothing * Time.deltaTime);

                yield return null;
            }
        }
    }
}
