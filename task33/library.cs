using System;
using System.Collections.Generic;
using System.Text;

namespace task33
{
    internal class library
    {
        private List<BOOK> books = new List<BOOK>();

        public void AddBook(BOOK book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully");
        }

        public void SearchBook(string sentence)
        {
            bool found = false;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title.ToLower().Contains(sentence.ToLower()))
                {
                    Console.WriteLine($" The Author is {books[i].Author} , Available: {books[i].IsAvailable}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Book not found");
            }
        }
        //borrow by tite

        public void BorrowBook(string title)
        {
            bool found = false;

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title.ToLower().Contains(title.ToLower()))
                {
                    found = true;

                    if (books[i].IsAvailable)
                    {
                        books[i].IsAvailable = false;
                        Console.WriteLine($"You have borrowed: {books[i].Title}");
                    }
                    else
                    {
                        Console.WriteLine("It's already borrowed");
                    }

                    return;
                }
            }

            if (!found)
            {
                Console.WriteLine("Book not found in the library");
            }
        }


        public void ReturnBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title.ToLower().Contains(title.ToLower()))
                {
                    if (!books[i].IsAvailable)
                    {
                        books[i].IsAvailable = true;
                        Console.WriteLine("Book returned successfully");
                    }
                    else
                    {
                        Console.WriteLine("Book was not borrowed");
                    }
                    return;
                }
            }

            Console.WriteLine("Book not found in the library");
        }
    }
}
