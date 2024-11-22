using BAB.Plugin.EFInfrastructureUtility;
using BabApps.APICaller.Models;
using FirstProject.Models.Repository;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Threading.Tasks.Dataflow;

namespace Evaluation.Models.Data
{
    public class StudentData : IDataRepository<Student>
    {
        private readonly StudentContext _studentContext;
        private readonly IRepository<Student> _studentRepository;
        public StudentData(StudentContext context, IRepository<Student> repository  )
        {
            _studentContext = context;
            _studentRepository = repository;
        }

        public Task<Student> FiSamplefilters(long id)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<Student> GetAll()
        {
            return _studentContext.Students.ToList();
        }
        public  Task<Student>Samplefilters(string name)
        {
            IList<DataFilter> filters = new List<DataFilter>();
            filters.Add(new DataFilter(nameof(Student.Name),  BabApps.APICaller.Models.Enum.DataFilterType.Equals,name));
            return (Task<Student>)_studentRepository.FilteredData(filters);
        }
    }
}
