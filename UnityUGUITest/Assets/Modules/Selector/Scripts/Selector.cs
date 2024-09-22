using NaughtyAttributes;
using UnityEngine;

namespace ImUGUISample.Selector
{
    public class Selector : MonoBehaviour
    {
        private Container _container;
        [SerializeField] private SelectionItem[] _selectionItems;

        public void Init(Container container)
        {
            _container = container;
            
            for (int i = 0; i < 4; i++)
            {
                var item = _selectionItems[i];
                item.Init(i);
                item.OnUpdateSelection += SelectedItem;
                item.OnConfirmSelection += Selected;
            }
            
        }
    
        public void UpdateItem()
        {
            var itemData = _container.ItemDataArr;
            
            for (int i = 0; i < _selectionItems.Length; i++)
            {
                var item = _selectionItems[i];
                var data = itemData[i];
                
                item.Show();
                item.SetData(data);
            }
        }

        private void SelectedItem(int index)
        {
            for (int i = 0; i < _selectionItems.Length; i++)
            {
                var item = _selectionItems[i];
                bool isSelected = i == index;

                if (isSelected) item.Select();
                else            item.Clear ();
                
            }
        }

        private void Selected(int index)
        {
            var itemData = _container.ItemDataArr[index];
            
            Debug.Log($"최종 선택된 아이템~ {itemData.Name}");
        }
    }
}