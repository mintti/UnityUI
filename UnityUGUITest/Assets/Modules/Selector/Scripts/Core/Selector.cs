using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

namespace ImUGUISample.Selector
{
    public class Selector : MonoBehaviour
    {
        [SerializeField] private SelectionItem[] _selectionItems;

        public UnityAction<int> OnSelected;
        
        public void Init()
        {
            for (int i = 0; i < 4; i++)
            {
                var item = _selectionItems[i];
                item.Init(i);
                item.OnUpdateSelection += SelectedItem;
                item.OnConfirmSelection += Selected;
            }
        }

        private void SelectedItem(int index)
        {
            for (int i = 0; i < _selectionItems.Length; i++)
            {
                var item = _selectionItems[i];
                bool isSelected = i == index;
                if (!isSelected) item.Clear();
            }
        }

        private void Selected(int index)
        {
            OnSelected?.Invoke(index);
        }
    }
}