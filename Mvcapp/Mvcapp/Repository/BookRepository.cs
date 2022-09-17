using Mvcapp.Models;
using System.Collections.Generic;
using System.Linq;

namespace Mvcapp.Reposotroy
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return dataSource();
        }
        public BookModel GetBookById(int id)
        {
            return dataSource().Where(x => x.Id == id).FirstOrDefault();

        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return dataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> dataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id=1, Title = "abc", Author = "xyz" },
                new BookModel() { Id=2, Title = "def", Author = "pqr" },
                new BookModel() { Id=3, Title = "ghi", Author = "jkl" },
               new BookModel() { Id=4, Title = "aaa", Author = "lmo" },
            };
        }

    }
}
