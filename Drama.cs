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

	class Drama : Work, IDramatic {
		public List<string> actions { get; set; }
		public List<string> dialogs { get; set; }
		public List<string> remarks { get; set; }

		public SubGenres subGenre { get; set; }
		public override List<Character> characters { get; set; }
	}
}