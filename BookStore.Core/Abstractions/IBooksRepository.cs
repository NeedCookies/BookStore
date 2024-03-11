using BookStore.Core.Models;

namespace BookStore.Core.Abstractions
{
    public interface IBooksRepository
    {
        Task<List<Book>> GetAll();
        Task<Guid> Create(Book book);
        Task<Guid> Update(Guid id, string title, string desc, decimal price);
        Task<Guid> Delete(Guid id);
    }
}
