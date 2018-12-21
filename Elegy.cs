using System;
using System.Collections.Generic;

namespace LiteratureAbstraction {
	public enum ElegyTypes {
		sad,
		love,
		warlike,
		political,
		accusatory,
		philosophical,
		autobiographical
	}

	class Elegy : Work, ILyric {
		public string sizeOfVerse { get; set; }
		public string rhyme { get; set; }
		public override List<Character> characters { get; set; }

		public ElegyTypes elegyType { get; set; }

		public Elegy(Author author, DateTime date, string name, string kind) : base(author, date, name, kind) {
		}

		public Elegy(Author author) : base(author) {
		}
	}
}