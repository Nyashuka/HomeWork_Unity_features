using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Features2.Coroutines
{
    public class CoroutinesExample : MonoBehaviour
    {
        [SerializeField] private float smoothing = 1f;
        [SerializeField] private Transform target;

        private void Start()
        {
            StartCoroutine(MyCoroutine(target));
        }


        private IEnumerator MyCoroutine(Transform target)
        {
            yield return new WaitForSeconds(3f);

            while (Vector3.Distance(transform.position, target.position) > 0.05f)
            {
                transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);
                yield return null;
            }

            print("Reached the target.");

            yield return new WaitForSeconds(3f);

            print("MyCoroutine is now finished.");
        }
    }
}
