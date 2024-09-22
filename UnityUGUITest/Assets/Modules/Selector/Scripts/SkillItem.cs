using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ImUGUISample.Selector
{
    public class SkillItem : MonoBehaviour
    {
        
        [SerializeField] private Button _selectButton;
        [SerializeField] private TextMeshProUGUI _itemLavel;
        
        [SerializeField] private SelectionItem _selectionItem;
        

        private void Start()
        {
            _selectButton.onClick.AddListener(_selectionItem.OnClicked);
        }
        
        public void SetData(ItemData data)
        {
            _itemLavel.text = data.Name;

            bool isActive = data.CheckUsable();
            _selectionItem.UpdateItem(isActive);
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }
        
        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}