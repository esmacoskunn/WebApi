using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        //private readonly Lazy<IBookRepository> _bookRepository;
        private readonly IBookRepository _bookRepository;

      //  Bu genişletme yöntemi, IRepositoryManager ayrılan projedeki servislerin yönetimini elde etmek üzere eklendiği ve yapılandırıldığı anlamında gelir.Bu sayede IRepositoryManager arayüzü üzerinden tanımlanmış metotlar ve özellikler, RepositoryManager sınıfı üzerinden gerçekleştirilmiş ve proje içinde kullanılabilir hale gelmiş olacaktır.

        public RepositoryManager(RepositoryContext context)
        {
            _context = context; 
            //_bookRepository = new Lazy<IBookRepository>(() => new BookRepository(_context));
            _bookRepository = new BookRepository(_context);


        }

        public IBookRepository Book => _bookRepository;


        public void save()
        {

            _context.SaveChanges();
        }
    }

}
