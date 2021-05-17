using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
	class Book
	{
		public string name;
		public string bookId;
		public string author;
		public string publisher;
		public string count;

		public Book(string name, string author, string publisher, string count, string bookId)
		{
			this.name = name;
			this.author = author;
			this.publisher = publisher;
			this.count = count;
			this.bookId = bookId;
		}
	}
}


