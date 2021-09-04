using System;
using BookManagementAppliction.Framework;

namespace BookManagementAppliction.Views
{
    public class BookCreateView
    {
        public BookCreateView()
        {
        }


        public void Render()
        {
            ViewHelp.WriteLine("CREATE A NEW BOOK", ConsoleColor.Green);

            string title = ViewHelp.InputString("Title: ", ConsoleColor.Magenta);

            string authors = ViewHelp.InputString("Authors: ", ConsoleColor.Magenta);

            string publisher = ViewHelp.InputString("Publisher: ", ConsoleColor.Magenta);

            int year = ViewHelp.InputInt("Year: ", ConsoleColor.Magenta);

            int edition = ViewHelp.InputInt("Edition: ", ConsoleColor.Magenta);

            bool reading =  ViewHelp.InputBool("Reading [y/n]", ConsoleColor.Magenta);

        }
    }

}