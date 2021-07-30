using System;
using System.Threading.Tasks;
using BookAPI.Models;
namespace BookAPI.Repositories
{
    public interface IBookRepository
    {
        Task<IEquatable<Book>> Get();

        Task<Book> Get(int Id);

        Task<Book> Create(Book book);

        Task Update(Book book);

        Task Delete(int Id);
    }
}
