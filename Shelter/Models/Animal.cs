namespace Shelter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Agression { get; set; }
        public bool Vacinated { get; set; }
        public bool Fixed { get; set; }
        public bool HouseTrained { get; set; }
    }
}