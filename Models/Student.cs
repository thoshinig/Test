using System.ComponentModel.DataAnnotations;

namespace Evaluation.Models
{
    public class Student
    {
        [Key]
        public int SId { get; set; }
        public string Name { get; set; }
        public string FatherName { get;set; }
        public string MotherName { get; set;}
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public ICollection<Education> Educations { get; set; }


    }
}
