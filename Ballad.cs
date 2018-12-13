﻿using System.Collections.Generic;

namespace LiteratureAbstraction {
	class Ballad : Work, IEpic, ILyric {
		public List<string> dialogs { get; set; }
		public List<string> remarks { get; set; }
		public int countOfEvents { get; }
		public string sizeOfVerse { get; set; }
		public string rhyme { get; set; }
		public override List<Character> characters { get; set; }

		public string plot;
		public string culmination;
		public string conclusion;
	}
}