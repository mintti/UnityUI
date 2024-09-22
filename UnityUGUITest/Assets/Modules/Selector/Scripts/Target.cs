using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ImUGUISample.Selector
{
    public class Target : MonoBehaviour
    {
        [SerializeField] private GameObject _targetMark;

        public void Init()
        {
            UnassignTarget();
        }
        
        public void AssignTarget()
        {
            SetTargetUI(true);
        }

        public void UnassignTarget()
        {
            SetTargetUI(false);
        }


        private void SetTargetUI(bool state) => _targetMark.SetActive(state);
    }
}