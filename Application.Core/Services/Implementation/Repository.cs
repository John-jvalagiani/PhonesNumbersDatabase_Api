using Aplication.Core.Data;
using Aplication.Core.Entities;
using Aplication.Core.Services.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Core.Services.Implementation
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly AplicationDbContext _context;
        protected readonly DbSet<TEntity> _set;

        public Repository(AplicationDbContext context)
        {
            _context = context;
            _set = _context.Set<TEntity>();
        }

        public abstract Task<bool> AddManyEntityAsync(IEnumerable<TEntity> entities);
        

        public  async Task<TEntity> AddEntityAsync(TEntity entity)
        {
            await _set.AddAsync(entity);

            return await SaveChanges() == true ? entity : null;


        }

        public async Task<bool> Delete(int Id)
        {
           var entity = _set.FindAsync(Id);

            if (entity == null)
                throw new ArgumentException($"Cannot find entity with Id {Id} ");


             _set.Remove(entity.Result);

            return await SaveChanges();


        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(int Id)
        {

            return await _set.ToListAsync();

        }

        public async Task<TEntity> GetByIdAsync(int Id)
        {
            return await _set.FindAsync(Id);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {

            var _entity =_set.Update(entity);

            return await SaveChanges() == true ? _entity.Entity : null;


        }

        protected async Task<bool> SaveChanges()=>(await _context.SaveChangesAsync()>0);


    }


}
