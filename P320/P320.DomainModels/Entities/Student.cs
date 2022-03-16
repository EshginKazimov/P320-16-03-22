using P320.DomainModels.Base;

namespace P320.DomainModels.Entities
{
    public class Student : TimestampableObject, IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }
    }
}
