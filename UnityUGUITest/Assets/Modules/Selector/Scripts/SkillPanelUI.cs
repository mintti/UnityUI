using NaughtyAttributes;
using UnityEngine;

namespace ImUGUISample.Selector
{
    public class SkillPanelUI : MonoBehaviour
    {
        private Container _container;
        [SerializeField] private SkillItem[] _skillItems;
        
        [SerializeField] private Selector _selector;

        public void Init(Container container)
        {
            _container = container;
            
            _selector.OnSelected += SelectedSkill;
            UpdateItem();
        }
        
        [Button("update")]
        private void UpdateItem()
        {
            var itemData = _container.ItemDataArr;
            
            for (int i = 0; i < _skillItems.Length; i++)
            {
                var item = _skillItems[i];
                var data = itemData[i];
                
                item.Show();
                item.SetData(data);
            }
        }
        
        private void SelectedSkill(int index)
        {
            var itemData = _container.ItemDataArr[index];
            
            Debug.Log($"최종 선택된 아이템~ {itemData.Name}");
        }
    }
}