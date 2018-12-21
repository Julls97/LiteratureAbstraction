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

		public Elegy(Author author, int year, string name) : base(author, year, name) {
		}

		public Elegy(Author author) : base(author) {
		}
	}
}