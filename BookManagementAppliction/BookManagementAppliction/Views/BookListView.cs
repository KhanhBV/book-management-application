using System;
using BookManagementAppliction.Framework;
using BookManagementAppliction.Models;

namespace BookManagementAppliction.Views
{
    public class BookListView
    {
        protected Book[] Model;

        public BookListView(Book[] model)
        {
            Model = model;
        }

        public void Render()
        {
            if(Model.Length == 0)
            {
                ViewHelp.WriteLine("No book found!", ConsoleColor.Yellow);
                return;
            }
            ViewHelp.WriteLine("THE BOOK LIST", ConsoleColor.Green);
            int i = 0;
            while(i < Model.Length)
            {
                ViewHelp.Write($"[{Model[i].Id}]", ConsoleColor.Yellow);
                ViewHelp.WriteLine($" { Model[i].Title}", Model[i].Reading ? ConsoleColor.Cyan : ConsoleColor.Blue);
                i++;
            }
        }
    }
}
