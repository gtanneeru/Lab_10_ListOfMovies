using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_ListOfMovies
{
    public class Movie

    {
        private string title = " ";
        private string category = " ";

        public Movie(string title, string category)
        {
            this.title = title;

            this.category = category;
        }

        public string Title
        {
            get {return title;}

            set { title = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
       
       



    }
}
