using System;
using BookManagementAppliction.Controllers;

namespace BookManagementAppliction
{
    class Program
    {
        static void Main(string[] args)
        {
            BookController bookController = new BookController();

            while (true)
            {
                Console.Write("Request> ");
                string request = Console.ReadLine();

                switch (request.ToLower())
                {
                    case "single":
                        bookController.Single(1);
                        break;

                    case "create":
                        bookController.Create();
                        break;
                    case "update":
                        bookController.Update(1);
                        break;


                    default:
                        Console.WriteLine("Unknow command");
                        break;
                }
            }
            bookController.Single(0);

            Console.ReadKey();
        }
    }
}
