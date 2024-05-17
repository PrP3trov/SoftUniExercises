namespace BorderControl.Models
{
    public class BorderControl
    {
        private List<BaseEntity> entities;
        public List<BaseEntity> EntitiesToBeChecked 
        {
            get => entities;            
        }
        public BorderControl()
        {
            entities = new List<BaseEntity>();
        }
        public void AddEntityForBorderCheck(BaseEntity entity)
        {
            entities.Add(entity);
        }
    }
}
