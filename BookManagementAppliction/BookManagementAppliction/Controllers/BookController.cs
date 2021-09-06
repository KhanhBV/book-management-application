using System;
using BookManagementAppliction.Models;
using BookManagementAppliction.Views;

namespace BookManagementAppliction.Controllers
{
    public class BookController
    {
        public void Single(int id)
        {
            Book model = new Book();
            BookSingleView view = new BookSingleView(model);
            view.Render();
        }

        public void Create()
        {
            BookCreateView view = new BookCreateView();
            view.Render();
        }

        public void Update(int id)
        {
            var model = new Book();
            var view = new BookUpdateView(model);
            view.Render();
        }

        public void List()
        {
            Book[] model = new Book[]
            {
                new Book{ Id = 1, Title =  "A new book 1" },
                new Book{Id=2, Title = "A new book 2"},
                new Book{Id = 3, Title = "A new book 3" }
            };

            BookListView bookListView = new BookListView(model);
            bookListView.Render();
        }
    }
}
 