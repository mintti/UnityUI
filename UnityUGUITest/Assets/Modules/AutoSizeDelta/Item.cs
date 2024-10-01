using System;
using DG.Tweening;
using UnityEngine;

namespace AutoSizeDelta
{
    public class Item : MonoBehaviour
    {
        private RectTransform _rect;
        private Vector2 _initSize;
        
        public void Start()
        {
            _rect = GetComponent<RectTransform>();
            _initSize = _rect.sizeDelta;
        }

        public void Active()
        {
            _rect.DOSizeDelta(_initSize * 1.3f, 0.5f);
        }

        public void Inactive()
        {
            _rect.DOSizeDelta(_initSize , 0.5f);
        }
    }
}