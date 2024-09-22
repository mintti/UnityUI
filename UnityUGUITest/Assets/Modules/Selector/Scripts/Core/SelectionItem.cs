using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ImUGUISample.Selector
{
    public class SelectionItem : MonoBehaviour
    {
        [SerializeField] private GameObject _selectedOB;

        public Action<int> OnUpdateSelection;
        public Action<int> OnConfirmSelection;

        private int _index;
        private bool _canSelect = true;
        private bool _isSelected;

        private bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                SetSelectedMark(value);
            }
        }

        /// <summary>
        /// 현재 선택지의 인덱스 지정 
        /// </summary>
        public void Init(int index)
        {
            _index = index;
            Clear();
        }

        public void UpdateItem(bool isActive)
        {
            _canSelect = isActive;
            Clear();
        }

        public void OnClicked()
        {
            if (!_canSelect)
            {
                Debug.Log( $"선택 불가능한 아이템이다.");
                OnUpdateSelection?.Invoke(-1);
                return;
            }
            
            OnUpdateSelection?.Invoke(_index);
            Select();
        }
        
        private void Select()
        {
            if (!_isSelected)
            {
                IsSelected = true;
            }
            else
            {
                // 확정 선택
                OnConfirmSelection?.Invoke(_index);
            }
        }

        public void Clear()
        {
            IsSelected = false;
        }

        private void SetSelectedMark(bool state)
        {
            _selectedOB.SetActive(state);
        }
    }
}