using System;
using System.Collections.Generic;

namespace LiteratureAbstraction {
	public enum PoemTypes {
		didactic,
		satirical,
		burlesque,
		romantic,
		lyricDramatic
	}

	class Poem : Work, IEpic, ILyric {
		public List<string> dialogs { get; set; }
		public List<string> remarks { get; set; }
		public int countOfEvents { get; }
		public string sizeOfVerse { get; set; }
		public string rhyme { get; set; }
		public override List<Character> characters { get; set; }
		public PoemTypes poemType { get; set; }

		public Poem(Author author, DateTime date, string name, string kind) : base(author, date, name, kind) {
		}

		public Poem(Author author) : base(author) {
		}
	}
}