using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFestival
{
	public class Genre
	{
		public string Name { get; set; }
		public Genre() { }


		private string GetData()
		{
			return !string.IsNullOrEmpty(Name) ? string.Format("{0}{1}", Name[0], Name[^1]) : "";
		}


	}
}
