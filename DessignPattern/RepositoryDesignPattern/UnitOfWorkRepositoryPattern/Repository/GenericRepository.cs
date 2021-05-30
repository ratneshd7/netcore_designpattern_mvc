
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkRepositoryPattern.DAL;
using UnitOfWorkRepositoryPattern.UnitOfWorks;


namespace UnitOfWorkRepositoryPattern.Repository
{
    public class GenericRepository<T> : IGenericRepository<T>, IDisposable where T : class
    {
        private readonly IUnitOfWork _unitOfWork;
        private Microsoft.EntityFrameworkCore.DbSet<T> _entities;
        public GenericRepository(IUnitOfWork unitOfWork) {
            this._unitOfWork = unitOfWork;
        }
        public void Delete(T obj)
        {
            _unitOfWork.Context.Remove(obj);
        }

        public void Dispose()
        {
            if (_unitOfWork.Context != null)
            _unitOfWork.Context.Dispose();
        }
        public void Save()
        {
            _unitOfWork.Save();
        }
        public IEnumerable<T> GetAll()
        {
            return _unitOfWork.Context.Set<T>().ToList(); 
        }

        public T GetById(object id)
        {
            //    .Include(_unitOfWork.Context.GetIncludePaths(typeof(T)))   
            T entity = _unitOfWork
                .Context
                .Set<T>()
                .Find(id);


            if (entity is null)
                throw new Exception("Entity not found " + typeof(T));
            return entity;
        }

        public void Insert(T obj)
        {
            _unitOfWork.Context.Set<T>().Add(obj);
            _unitOfWork.Save();
        }

        public void Update(T obj)
        {
            _unitOfWork.Save();
            _unitOfWork.Context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        }
    }
}
