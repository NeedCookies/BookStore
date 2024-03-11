using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Core.Models;

namespace BookStore.DataAccess.Repositories
{
    public interface IBooksRepository
    {
        public Task<List<Book>> GetAll();
        public Task<Guid> Create(Book book);
        public Task<Guid> Update(Guid id, string title, string desc, decimal price);
        public Task<Guid> Delete(Guid id);
    }
}
