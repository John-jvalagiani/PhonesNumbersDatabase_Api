using Aplication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Core.Services.Abstraction
{
    public interface IRepository<Tentity>where Tentity:BaseEntity
    {

        Task<Tentity> AddEntityAsync(Tentity entity);
        Task<bool> AddManyEntityAsync(IEnumerable<Tentity> entities);
        Task<bool> Delete(int Id);
        Task<Tentity> UpdateAsync(Tentity entity);
        Task<Tentity> GetByIdAsync(int Id);
        Task<IEnumerable<Tentity>> GetAllAsync(int Id);


    }
}
