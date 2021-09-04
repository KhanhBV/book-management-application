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
    }
}
 