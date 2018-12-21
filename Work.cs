using System;
using System.Collections.Generic;

namespace LiteratureAbstraction {
	public abstract class Work {
		public Author author { get; private set; }
		public DateTime date { get; set; }
		public string name { get; set; }
		public string kind { get; set; }
		public abstract List<Character> characters { get; set; }

		public int CompareTo(object obj) {
			Work other = (Work) obj;
			return String.Compare(author.lastName, other.author.lastName, StringComparison.Ordinal);
		}

		public Work(Author author, DateTime date, string name, string kind) {
			this.author = author;
			this.date = date;
			this.name = name;
			this.kind = kind;
		}
		
		public Work(Author author) {
			this.author = author;
		}
	}
}