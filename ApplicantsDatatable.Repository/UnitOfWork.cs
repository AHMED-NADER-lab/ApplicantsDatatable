using ApplicantsDatatable.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantsDatatable.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Members
        readonly ApplicantContext _context;
        #endregion

        #region Constructor
        public UnitOfWork(ApplicantContext context
            )
        {
            _context = context;
        }

        #endregion

        #region IUnitOfWork Members     

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public DbSet<TEntity> CreateSet<TEntity>()
            where TEntity : class
        {
            var set = _context.Set<TEntity>();
            return set;
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            _context.Dispose();
        }

        #endregion

 
   

    }
}
