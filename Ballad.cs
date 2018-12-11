using System.Collections.Generic;

namespace Literature {
	class Ballad : IEpic, ILyric {
		public List<string> dialogs { get; set; }
		public List<string> remarks { get; set; }
		public int countOfEvents { get; }
		public string sizeOfVerse { get; set; }
		public string rhyme { get; set; }
	}
}