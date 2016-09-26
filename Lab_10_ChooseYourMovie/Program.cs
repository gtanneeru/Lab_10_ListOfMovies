using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_10_ListOfMovies;

namespace Lab_10_ChooseYourMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string yes = " ";
            string go= "";
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 100 Movies in this list!");
              do
              {
                  Console.WriteLine("What Category are you interested in?");
                  Console.WriteLine("Please enter: drama or musical or scifi or comedy or horror or animated!");
                  string movieCategory = Console.ReadLine();
                  MovieIO catalogLength = new MovieIO();


                  foreach (Movie movie in MovieIO.default_MovieCatalog.OrderBy(m => m.Title))
                  {

                      if (movie.Category == movieCategory)

                          Console.WriteLine("Movie Title\t"+movie.Title);



                  }
                  Console.WriteLine("Want to search more! (y/n)");
                  yes = Console.ReadLine();

              }

              while (yes == "y");



            //Extended Excercises:
do { 
            Console.WriteLine("Enter a category number:\n 1 for Animated \n 2 for comedy \n 3 for drama \n 4 for horror \n 5 for musical \n 6 for scifi  ");
            string index = Console.ReadLine();

                switch (index)
                {
                    case "1":

                        foreach (Movie movie in MovieIO.default_MovieCatalog)
                        {
                            if (movie.Category == "animated")

                                Console.WriteLine(movie.Title);
                        }
                        break;

                    case "2":

                        foreach (Movie movie in MovieIO.default_MovieCatalog)
                        {
                            if (movie.Category == "comedy")

                                Console.WriteLine(movie.Title);
                        }
                        break;

                    case "3":
                        foreach (Movie movie in MovieIO.default_MovieCatalog)
                        {
                            if (movie.Category == "drama")

                                Console.WriteLine(movie.Title);
                        }
                        break;
                    case "4":
                        foreach (Movie movie in MovieIO.default_MovieCatalog)
                        {
                            if (movie.Category == "horror")

                                Console.WriteLine(movie.Title);
                        }
                        break;
                    case "5":
                        foreach (Movie movie in MovieIO.default_MovieCatalog)
                        {
                            if (movie.Category == "musical")

                                Console.WriteLine(movie.Title);
                        }
                        break;
                    case "6":
                        foreach (Movie movie in MovieIO.default_MovieCatalog)
                        {
                            if (movie.Category == "scifi")

                                Console.WriteLine(movie.Title);
                        }
                        break;

                    default:
                        break;
                }
                Console.WriteLine("\n\n Want to seach more!"+" "+ "Enter"+ "  "+ "\"y\" "+ " "+ "\"n\"");
                go = Console.ReadLine();
            }
            while (go == "y");
            
        }
    }
}
    



   
