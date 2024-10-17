using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFestival
{
    public class Genre
    {
        public string?Name { get; set; }

        public string GetData()
        {
            return Name[0] + " " + Name[(Name.Length) - 1];
        }
    }
}
