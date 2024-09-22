using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

namespace ImUGUISample.Selector
{
    public class Container : MonoBehaviour
    {
        private Main _main;
        
        [SerializeField] private Target[] _targets;
        [SerializeField] private ItemData[] dataArr;
        
        public Target[] Targets => _targets;
        
        public ItemData[] ItemDataArr => dataArr;

        public void Init(Main main)
        {
            _main = main;
            
            foreach (var target in _targets)
            {
                target.Init();
            }
        }

        [Button("update")]
        private void UpdateData()
        {
            _main.Selector.UpdateItem();
        }
        
    }
}