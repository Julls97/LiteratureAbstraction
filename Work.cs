using System;
using System.Collections.Generic;

namespace LiteratureAbstraction {
	public abstract class Work {
		public Author author { get; private set; }
		public DateTime year { get; set; }
		public string name { get; set; }
		public abstract List<Character> characters { get; set; }

		public virtual string GetDescription() {
			string s =  "Дорогой читатель! Ты держишь в руках книгу " + name + ", которую написал " +
			       author.firstName + " " + author.lastName +
			       ". Это произведение было написано в " + year.Year +
			       " году. В этой книге ты прочитаешь про ";
			return s;
		}

		public int CompareTo(object obj) {
			Work other = (Work) obj;
			return String.Compare(author.lastName, other.author.lastName, StringComparison.Ordinal);
		}

		public Work(Author author, DateTime year, string name) {
			this.author = author;
			this.year = year;
			this.name = name;
		}

		public Work(Author author) {
			this.author = author;
		}
	}
}