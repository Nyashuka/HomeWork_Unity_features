using UnityEngine;

namespace Assets.Scripts.Features1.Events
{
    public class TurnColorScript : MonoBehaviour
    {
        private Renderer _renderer;

        private void Start()
        {
            _renderer = GetComponent<Renderer>();
        }

        private void OnEnable()
        {
            EventManager.OnClicked += TurnColor;
        }


        private void OnDisable()
        {
            EventManager.OnClicked -= TurnColor;
        }

        public void TurnColor()
        {
            _renderer.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
