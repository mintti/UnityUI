using UnityEngine;
using UnityEngine.EventSystems;

namespace ImUGUISample.Selector
{
    public class Target : MonoBehaviour, IPointerClickHandler 
    {
        [SerializeField] private SelectionItem _item;
        
        
        
        public void OnPointerClick(PointerEventData eventData)
        {
            _item.OnClicked();
        }
    }
}