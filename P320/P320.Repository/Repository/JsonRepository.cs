using P320.DomainModels.Base;
using P320.Repository.Repository.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace P320.Repository.Repository
{
    public class JsonRepository<T> : IRepository<T> where T : class, IEntity
    {
        public Task AddAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task AddAsync(IEnumerable<T> entity)
        {
            throw new System.NotImplementedException();
        }

        public Task AddAsync(params T[] entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(IEnumerable<T> entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(params T[] entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<T>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<T> GetAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(IEnumerable<T> entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(params T[] entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
