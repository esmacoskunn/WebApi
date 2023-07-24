using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        // Soyut sınıflar, doğrudan örneklenemez ve genellikle alt sınıflar tarafından genişletilir.

        protected readonly RepositoryContext _context;
        public RepositoryBase(RepositoryContext context) //burada generic yapıları ve veritabanı işlemlerini birbiriyle bağımlı yaptı. //RepositoryBase ,,RepositoryContext E BAĞIMLI NEYLE _CONTEX İLE BİRBİNE BAĞLANDI.......
        {
            _context = context;
        }
        //iki sınıfı biririyle bağımlı yapar. generic yapılar ve bunları veri tabanına kaydetme işleleriberaber olucak 

        public void Create(T entitiy) => _context.Set<T>().Add(entitiy); //buraddaki generic yapılar RepositoryBase geldi. veri tabanı bağlantısı RepositoryContext den geldi.

        public void Delete(T entitiy) => _context.Set<T>().Remove(entitiy); //buralara değer gelicek.başka yerlerden.

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
            _context.Set<T>().AsNoTracking() :
            _context.Set<T>();
        //tamamını getir.

        public IQueryable<T> FindByCodition(Expression<Func<T, bool>> expression, bool trackChanges) =>
               !trackChanges ?
            _context.Set<T>().Where(expression).AsNoTracking() :
            _context.Set<T>().Where(expression);


        public void Update(T entitiy) => _context.Set<T>().Update(entitiy);

    }
}
