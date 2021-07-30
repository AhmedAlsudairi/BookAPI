using System;
using System.Threading.Tasks;
using BookAPI.Models;

namespace BookAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext _contesxt;
        public BookRepository(BookContext context)
        {
            _contesxt = context;
        }

        Task<Book> IBookRepository.Create(Book book)
        {
            throw new NotImplementedException();
        }

        Task IBookRepository.Delete(int Id)
        {
            throw new NotImplementedException();
        }

        Task<IEquatable<Book>> IBookRepository.Get()
        {
            throw new NotImplementedException();
        }

        Task<Book> IBookRepository.Get(int Id)
        {
            throw new NotImplementedException();
        }

        Task IBookRepository.Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
