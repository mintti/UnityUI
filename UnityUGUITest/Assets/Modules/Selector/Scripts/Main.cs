using UnityEngine;

namespace ImUGUISample.Selector
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private Container _container;
        [SerializeField] private Selector _selector;
        
        public Selector Selector => _selector;
        private void Start()
        {
            _container.Init(this);
            _selector.Init(_container);
        }
    }
}