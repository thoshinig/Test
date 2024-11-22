using Evaluation.Models;
using Microsoft.JSInterop;
using System.Xml.Serialization;

namespace FirstProject.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        Task<Student> FiSamplefilters(long id  );
       // TEntity Get(long id);
       // public void Add(TEntity entity);
       // void Update(TEntity dbEntity, TEntity entity);
       // void Update(TEntity dbEntity, TEntity entity);
    }
}
