using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositoryBase<T>   //generic olan proplar  burada
    { 
        IQueryable<T> FindAll(bool trackChanges);
        //trackChanges: Bu parametre, varlık sınıfının değişiklik izleme (change tracking) durumunu belirtir. Eğer trackChanges değeri true ise, değişiklik izleme etkinleştirilir ve geri dönüş değeri değiştirilebilir. Eğer trackChanges değeri false ise, değişiklik izleme devre dışı bırakılır ve geri dönüş değeri salt okunur olur.

        IQueryable<T> FindByCodition(Expression<Func<T,bool>> expressionbool,bool trackChanges); //şartlı sorgulama

        void Create(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);

    }
}
