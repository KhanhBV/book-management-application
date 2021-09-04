using System;
using BookManagementAppliction.Framework;
using BookManagementAppliction.Models;

namespace BookManagementAppliction.Views
{
    public class BookSingleView
    {
        protected Book Model;

        public BookSingleView(Book model)
        {
            Model = model;
        }

        public void Render()
        {
            if (Model == null)
            {
                ViewHelp.WriteLine("NO BO FOUND, SORRY", ConsoleColor.Red);
                return;
            }

            ViewHelp.WriteLine("BOOK DETAILS INFORMATION", ConsoleColor.Green);

            /*
             * 
             */
            Console.WriteLine($"Authors:        {Model.Authors}");
            Console.WriteLine($"Title:          {Model.Title} ");
            Console.WriteLine($"Year:           {Model.Year}");
            Console.WriteLine($"Edition:        {Model.Edition}");
            Console.WriteLine($"Isbn:           {Model.Isbn}");
            Console.WriteLine($"Tags:           {Model.Tags}");
            Console.WriteLine($"Description:    {Model.Description}");
            Console.WriteLine($"Raiting:        {Model.Rating}");
            Console.WriteLine($"Reading:        {Model.Reading}");
            Console.WriteLine($"File:           {Model.File}");
            Console.WriteLine($"File Name:      {Model.FileName}");

        }
    }
}
