using BorderControl.Models.Interfaces;

namespace BorderControl.Models
{
    public class Robot : BaseEntity
    {
        public Robot(string id, string model)
        {
            Id = id;
            Model = model;
        }
        public string Model { get; init; }
    }
}
