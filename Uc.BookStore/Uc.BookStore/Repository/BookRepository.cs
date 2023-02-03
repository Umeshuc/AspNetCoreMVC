using System.Collections.Generic;
using System.Linq;
using Uc.BookStore.Models;

namespace Uc.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();

        }

        private List<BookModel>DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id =1, Title="MVC", Author = "uc"},
                new BookModel(){Id =2, Title="Java", Author = "Suraj"},
                new BookModel(){Id =3, Title="C#", Author = "Nitish"},
                new BookModel(){Id =4, Title="PHP", Author = "Akshya"},
                new BookModel(){Id =5, Title="ASP", Author = "temp"}
            };
        }


    }
}
