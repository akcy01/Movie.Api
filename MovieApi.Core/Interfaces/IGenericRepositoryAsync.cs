using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Core.Interfaces
{
    public interface IGenericRepositoryAsync<TEntity> where TEntity : class
    {
           Task<ICollection<TEntity>> GetAsync();
           Task<TEntity> GetByIdAsync(int id);
           Task<TEntity> CreateAsync(TEntity entity);
           Task<TEntity> UpdateAsync(TEntity entity);   
           Task DeleteByIdAsync(int id);
           
    }
}
