using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ImUGUISample.Selector
{
    public class SelectionItem : MonoBehaviour
    {
        [SerializeField] private Button _selectButton;
        [SerializeField] private TextMeshProUGUI _itemLavel;
        [SerializeField] private GameObject _selectedOB;

        public Action<int> OnUpdateSelection;
        public Action<int> OnConfirmSelection;

        private int _index;
        private bool _canSelect;
        private bool _isSelected;

        private void Start()
        {
            _selectButton.onClick.AddListener(OnClicked);
        }

        public void Init(int index)
        {
            _index = index;
            Clear();
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }
        
        public void Hide()
        {
            gameObject.SetActive(false);
        }
        
        public void SetData(ItemData data)
        {
            _itemLavel.text = data.Name;

            bool isActive = data.CheckUsable();
            _canSelect = isActive;
            
            Clear();
        }

        private void OnClicked()
        {
            if (!_canSelect)
            {
                Debug.Log( $"{_itemLavel.text}는 선택 불가능한 아이템이다.");
                OnUpdateSelection?.Invoke(-1);
                return;
            }
            
            OnUpdateSelection?.Invoke(_index);
        }
        
        public void Select()
        {
            if (!_isSelected)
            {
                _isSelected = true;
                _selectedOB.SetActive(true);
            }
            else
            {
                // 스킬 확정 사용
                OnConfirmSelection?.Invoke(_index);
            }
            
        }

        public void Clear()
        {
            _isSelected = false;
            _selectedOB.SetActive(false);
        }
    }
}