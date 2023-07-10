using MagicVillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVillaAPI.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        //Task CreateAsync(Villa entity);
        //Task RemoveAsync(Villa entity);

        Task<Villa> UpdateAsync(Villa entity);

        //Task SaveAsync();
        //Task<List<Villa>> GetAllAsync(Expression<Func<Villa,bool>> filter =null);

        //Task<Villa> GetAsync(Expression<Func<Villa,bool>> filter = null, bool tracked=true);
    }
}
