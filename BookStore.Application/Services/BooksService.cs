using BookStore.Core.Models;
using BookStore.Core.Abstractions;

namespace BookStore.Application.Services
{
    //BookStore.Application - слой с бизнес логикой, Services - отвечают за связь котроллеров с БД

    /// <summary>
    /// Gets all the data from repositories
    /// </summary>
    public class BooksService : IBooksService
    {
        private readonly IBooksRepository _booksRepository;

        public BooksService(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await _booksRepository.GetAll();
        }

        public async Task<Guid> CreateBook(Book book)
        {
            return await _booksRepository.Create(book);
        }

        public async Task<Guid> UpdateBook(Guid id, string title, string description, decimal price)
        {
            return await _booksRepository.Update(id, title, description, price);
        }

        public async Task<Guid> DeleteBook(Guid id)
        {
            return await _booksRepository.Delete(id);
        }
    }
}
