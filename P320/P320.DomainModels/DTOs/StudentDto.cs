using P320.DomainModels.Base;
using System.ComponentModel.DataAnnotations;

namespace P320.DomainModels.DTOs
{
    public class StudentDto : IDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public int Age { get; set; }
    }
}
