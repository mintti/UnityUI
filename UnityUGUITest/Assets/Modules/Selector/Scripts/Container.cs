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
        [SerializeField] private Selector _targetSelector;
        
        public Target[] Targets => _targets;
        
        public ItemData[] ItemDataArr => dataArr;

        public void Init(Main main)
        {
            _main = main;
            _targetSelector.Init();
        }
        
    }
}