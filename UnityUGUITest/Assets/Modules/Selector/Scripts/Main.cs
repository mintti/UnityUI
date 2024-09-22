using UnityEngine;

namespace ImUGUISample.Selector
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private Container _container;
        [SerializeField] private SkillPanelUI _skillPanelUI;
        [SerializeField] private Selector _selector;
        private void Start()
        {
            _container.Init(this);
            _skillPanelUI.Init(_container);
            _selector.Init();
        }
    }
}