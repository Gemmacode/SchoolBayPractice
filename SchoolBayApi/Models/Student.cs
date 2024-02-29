using System.ComponentModel.DataAnnotations;

namespace SchoolBayApi.Models
{
    public class Student
    {
        [Key]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {MiddleName} {LastName}";
    }
}
