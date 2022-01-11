using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantsDatatable.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
          where TEntity : class
    {
        private readonly IUnitOfWork _unitOfWork;
        public Repository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public IQueryable<TEntity> GetAll()
        {

            return _unitOfWork.CreateSet<TEntity>();
        }



        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate != null)
            {
                return GetAll().Where(predicate);
            }
            else
            {
                throw new ArgumentNullException("The <predicate> paramter is required.");
            }
        }
      
      
        public TEntity GetFirst(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate != null)
            {
                IQueryable<TEntity> query = GetAll().Where(predicate);
                return query.FirstOrDefault();
            }
            else
            {
                throw new ArgumentNullException("The <predicate> paramter is required.");
            }



        }

        public void Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            var dbSet = _unitOfWork.CreateSet<TEntity>();
            dbSet.Add(entity);

        }
        public void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            var dbSet = _unitOfWork.CreateSet<TEntity>();
            dbSet.Update(entity);
        }
        public async Task<int> SaveChanges()
        {
            return await _unitOfWork.SaveChangesAsync();
        }




        public void Delete(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            var dbSet = _unitOfWork.CreateSet<TEntity>();
            dbSet.Remove(entity);
        }
    }
}
