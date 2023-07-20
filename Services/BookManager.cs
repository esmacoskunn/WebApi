using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookManager : IBookService
    {
        private readonly IRepositoryManager _manager;

        public BookManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public Book CreateOneBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteOneBook(int id, Book book)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooks(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Book GetOneBookById(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateOneBook(int id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
