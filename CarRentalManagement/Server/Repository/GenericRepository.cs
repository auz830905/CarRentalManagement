using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> entity;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            entity = context.Set<T>();
        }
        public async Task Delete(int id)
        {
            var record = await entity.FindAsync(id);
            entity.Remove(record);          
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            entity.RemoveRange(entities);
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null)
        {
            IQueryable<T> query = entity;

            if (includes != null)
            {
                foreach (var prop in includes)
                {
                    query = query.Include(prop);
                }
            }

            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<string> includes = null)
        {
            IQueryable<T> query = entity;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (includes != null)
            {
                foreach (var prop in includes)
                {
                    query = query.Include(prop);
                }
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Insert(T entity)
        {
            await this.entity.AddAsync(entity);
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            await entity.AddRangeAsync(entities);
        }

        public void Update(T entity)
        {
            this.entity.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

        }
    }
}
