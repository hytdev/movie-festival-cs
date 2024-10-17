using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFestival
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Length { get; set; }

        public string GetData()
        {
            return Title + "" + Genre + "" + Length;
        }
    }
}
