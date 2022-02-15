using System;
using System.Collections.Generic;

namespace Console_App_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = {"string", "string", "string", "string", "string"};
            Console.WriteLine("Input some text");
            string text = Console.ReadLine();

            // concatenates array item with user input
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i] + " " + text;
            }

            // writes concatendated string
            for (int j = 0; j < strings.Length; j++)
            {
                Console.WriteLine(strings[j]);
            }

            // fixed for loop
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }

            // less than for loop 
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine(k);
            }

            // less than or equals to for loop
            for (int m = 10; m <= 20; m++)
            {
                Console.WriteLine(m);
            }

            // searches list for user submitted subtext
            List<string> items = new List<string> { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };

            Console.WriteLine("Input text to search for in the list");
            string searchText = Console.ReadLine();
            int tracker = 0;
            for (int y = 0; y < items.Count; y++)
            {
                
                if (items[y].Contains(searchText))
                { 
                    Console.WriteLine(y);
                    break;  //code exits when found
                }
                // if subtext isn't found, tracker is incremented
                // if tracker matches the lenght of the list (no matches), no match was found
                tracker++;
                if (tracker == items.Count)
                {
                    Console.WriteLine("Subtext not found");
                }
            }

            List<string> newItems = new List<string> { "Item 1", "Item 1", "Item 3", "Item 4", "Item 5" };


            Console.WriteLine("Input text to search for in the list");
            string newSearchText = Console.ReadLine();
            int newTracker = 0;
            for (int y = 0; y < newItems.Count; y++)
            {

                if (items[y].Contains(newSearchText))
                {
                    Console.WriteLine(y);
                    newTracker--;
                }
                newTracker++;
                if (newTracker == items.Count)
                {
                    Console.WriteLine("Subtext not found");
                }
            }

            // searches all previous list entries for matches
            List<string> newerItems = new List<string> { "Apple", "Item 2", "Item 3", "Apple", "Item 5", "Apple", "Item 2", "Item 3", "Apple", "Item 5" };
            int searchLength = 0;
            foreach (string item in newerItems)
            {
                int counter = 1;
                // checks list of all previous items
                for (int i = 0; i < searchLength; i++)
                {
                    // increments counter if match is found
                    if (item == newerItems[i])
                    {
                        counter++;
                    }
                }
                // saves programming from index error 
                if (searchLength < newerItems.Count)
                {
                    searchLength++;
                }
                else
                {
                    break;
                }
                // prints the item string and the number of matches found at the time of printing
                Console.WriteLine(item + " has been found " + counter + " time(s)!");
            }
            Console.ReadLine();
        }
    }
}
