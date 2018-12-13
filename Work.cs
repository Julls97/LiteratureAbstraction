using System;
using System.Collections.Generic;

namespace LiteratureAbstraction {
	public abstract class Work {
		public Author author { get; private set; }
		public DateTime date { get; set; }
		public string name { get; private set; }
		public string genre { get; private set; }
		public string kind { get; private set; }
		public abstract List<Character> characters { get; set; }

		public int CompareTo(object obj) {
			Work other = (Work) obj;
			return String.Compare(author.lastName, other.author.lastName, StringComparison.Ordinal);
		}
	}
}