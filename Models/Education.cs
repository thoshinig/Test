using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluation.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string EducationType { get; set; }
        public string SchoolOrCollege { get; set; }
        public double Percentage { get;set; }
        public string YearOfPassing { get; set; }
        [ForeignKey(nameof(student))]
        public int SId { get; set; }

      
        public Student student { get; set; }
    }
}
