using System;
using System.Collections.Generic;
using System.Globalization;

namespace LiteratureAbstraction {
	public abstract class Work {
		public Author author { get; private set; }
		public DateTime date { get; set; }
		public string name { get; set; }
		public abstract List<Character> characters { get; set; }


		private CultureInfo provider = CultureInfo.InvariantCulture;

		public int Year {
			get { return date.Year; }
			set {
				date = new DateTime();
				date.AddYears(value);
			}
		}

		public virtual string GetDescription() {
			string s = "";
			return s;
		}

		public int CompareTo(object obj) {
			Work other = (Work) obj;
			return String.Compare(author.lastName, other.author.lastName, StringComparison.Ordinal);
		}

		public Work(Author author, DateTime date, string name) {
			this.author = author;
			this.date = date;
			this.name = name;
		}

		public Work(Author author) {
			this.author = author;
		}
	}
}