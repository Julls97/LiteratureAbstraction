using System;
using System.Collections.Generic;

namespace LiteratureAbstraction {
	public enum SubGenres {
		Melodrama,
		Psychological,
		Absurd,
		Symbolist,
		Existential,
		Other
	}

	public class Drama : Work, IDramatic {
		public List<string> actions { get; set; }
		public List<string> dialogs { get; set; }
		public List<string> remarks { get; set; }

		public SubGenres subGenre { get; set; }
		public override List<Character> characters { get; set; }

		public Drama(Author author, DateTime date, string name, string kind) : base(author, date, name, kind) {
		}

		public Drama(Author author) : base(author) {
		}
	}
}