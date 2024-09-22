namespace ImUGUISample.Selector
{
    [System.Serializable]
    public class ItemData
    {
        public string Name;
        public bool IsUse = true;
        
        public bool CheckUsable()
        {
            return IsUse;
        }
    }
}