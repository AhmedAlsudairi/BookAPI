using System;
using System.Threading.Tasks;
using BookAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext _contesxt;
        public BookRepository(BookContext context)
        {
            _contesxt = context;
        }

        public async Task<Book> Create(Book book)
        {
            _contesxt.Books.Add(book);
            await _contesxt.SaveChangesAsync();

            return book;
        }

        public async Task Delete(int Id)
        {
            var bookToDelete = await _contesxt.Books.FindAsync(Id);
            _contesxt.Books.Remove(bookToDelete);
            await _contesxt.SaveChangesAsync();
        }

        public async Task<IEquatable<Book>> Get()
        {
            return (IEquatable<Book>)await _contesxt.Books.ToListAsync();
        }

        public async Task<Book> Get(int Id)
        {
            return await _contesxt.Books.FindAsync(Id);
        }

        public async Task Update(Book book)
        {
            _contesxt.Entry(book).State = EntityState.Modified;
            await _contesxt.SaveChangesAsync();
        }
    }
}
