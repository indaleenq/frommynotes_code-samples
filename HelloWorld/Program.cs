using System;
using System.Collections.Generic;

namespace HelloWorld
{
    internal class Program
    {
        static List<string> booktitles = new List<string>();
        static void Main(string[] args)
        {
            //List<string> booktitles = new List<string>();

            booktitles.Add("Brain Rules");
            booktitles.Add("Deep Work");
            booktitles.Add("The Spy");
            booktitles.Add("The Code");
            booktitles.Insert(4, "Start with Why");

            booktitles.Remove("Deep");

            Console.WriteLine("Before AddRange: ");
            DisplayListContents();

            //for (int i = 0; i < booktitles.Count; i++)
            //{
            //    booktitles[i] = booktitles[i].ToUpper();
            //    Console.WriteLine(booktitles[i]);
            //}


            var books = new List<string>() { "Code 1", "Code 2", "Code 3" };
            books.Add("Book 4");

            booktitles.AddRange(books);

            Console.WriteLine("\nAfter AddRange(): ");
            DisplayListContents();

            Console.WriteLine($"The list contains {booktitles.Count} books");

            //Console.Write("\nEnter the book title that you want to search: ");
            //var searchTitle = Console.ReadLine();

            //if (booktitles.Contains(searchTitle))
            //{
            //    Console.WriteLine("Item found");
            //}
            //else
            //{
            //    Console.WriteLine("Item not found");
            //}

            Console.Write("\nEnter the book title that you want to search: ");
            var searchTitle = Console.ReadLine();
            var result = booktitles.Find(x => x == searchTitle);

            if (result != null)
            {
                Console.WriteLine("Item foundfound");
            }
            else
            {
                Console.WriteLine("Item not found");
            }

            booktitles.Sort();
            Console.WriteLine("\nAfter Sort()");
            DisplayListContents();

            booktitles.Reverse();
            Console.WriteLine("\nAfter Reverse()");
            DisplayListContents();

            booktitles.RemoveRange(2, 3);
            Console.WriteLine("\nAfter RemoveRange()");
            DisplayListContents();

            Console.WriteLine($"The list contains {booktitles.Count} books");
        }

        static void DisplayListContents()
        {
            foreach (var book in booktitles)
            {
                Console.WriteLine(book);
            }
        }
    }
}