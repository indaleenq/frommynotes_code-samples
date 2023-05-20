using System;
using System.Collections.Generic;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //data type
            //strongly-type

            string[] booktitles; //declaration

            Console.WriteLine("how many book do you want to save?");
            int numberOfBooks = Convert.ToInt16(Console.ReadLine());

            booktitles = new string[numberOfBooks]; //initialization

            //booktitles[0] = "Deep Work";
            //booktitles[3] = "Brain Rules";
            //booktitles[2] = "Harry Potter";

            for (int i = 0; i < numberOfBooks; i++)
            {
                Console.Write($"Input the title of Book {i + 1} :");
                var title = Console.ReadLine();

                booktitles[i] = title;
            }

            //Console.WriteLine(booktitles[3]);
            //Console.WriteLine(booktitles[4]);

            foreach(var book in booktitles)
            {
                Console.WriteLine(book) ;
            }

            for (int i = 3; i < booktitles.Length - 1 ; i++)
            {
                booktitles[i] = booktitles[i] + "!!!";
                Console.WriteLine(booktitles[i]);
            }


            Console.WriteLine("Enter the title of the book that you want to search");
            Console.Write("Book Title: ");
            var searchTitle = Console.ReadLine();

            var result = Array.IndexOf(booktitles, searchTitle);
            //returns -1 if the item being searched is not existing in the array,
            //else it will return the position index of the item

            if (result != -1)
            {
                Console.WriteLine($"The index of the {searchTitle} is {result}.");
                booktitles.SetValue(searchTitle.ToUpper(), result);
            }
            else
            {
                Console.WriteLine("Item not found!");
            }

            foreach (var book in booktitles)
            {
                Console.WriteLine(book);
            }
        }
    }
}