using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace running
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<book> books = new List<book>
            {
                new book
                { Title = " Efunshetananiwura",
                  Author = " Tunde edujobi",
                  Year= 1995,
                  Genre= "Acient war",

                },
              new book
               {
                  Title= " Ageshinkole",
                  Author = "FemiAdebayo",
                  Year = 2022,
                  Genre= "Revenge",

               },
              new book
              {Title = "Anikulapo",
               Author = " Kunle Afolayan",
               Year = 2022,
               Genre= " Betrayal",

              },

              new book
              {Title = "King of boys",
               Author = " Kemi Adetiba",
               Year = 2021,
               Genre= " politics",

              },


                new book
              {Title = "Black Panters",
               Author = " warners bros",
               Year = 2020,
               Genre= " Animations",

              },



           };
           
                  
                    


                   // displayTitle();
                   // oldestbook();
                   //groupByAuthor();
                     LongestTitle();


            void displayTitle()
            {
               var book= from hub in books
                         where hub.Year > 1998
                         select hub;
               foreach (var items in book)
               {
                   Console.WriteLine($"This is the book title  that was publsihed after 1998 {items.Title}");
                   Console.ReadLine();
               }


            }


               void oldestbook()
            {
                var sort = books.OrderBy(book => book.Year).First();
                Console.WriteLine($"The oldest book in the collections is{sort.Title} ");

            }


            void groupByAuthor()
            {
                var filter = books
                          .GroupBy(books => books.Author)
                          .Select(group => new
                          {
                              Author = group.Key,
                              Count = group.Count()
                          });

                foreach (var  item in filter)
                {
                    Console.WriteLine($"{item.Count}:{item.Author}");
                    Console.ReadLine();
                }



            }

            void LongestTitle()
            {
                var josh = books.OrderBy(l => l.Title).First();
                Console.WriteLine($"The longest title in the books series is {josh.Title}");

            }








        }



    }   }

        
    
