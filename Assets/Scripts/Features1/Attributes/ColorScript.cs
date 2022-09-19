using System;
using UnityEngine;

namespace Scripts.Features1.Attributes
{
    [ExecuteInEditMode]
    public class ColorScript : MonoBehaviour
    {       
        [SerializeField] private Color _color;

        private void Start()
        {
            GetComponent<Renderer>().sharedMaterial.color = _color;
        }
    }
}