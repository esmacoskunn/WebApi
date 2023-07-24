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
