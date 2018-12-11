using System.Collections.Generic;

namespace LiteratureAbstraction {
	class Novel : Work, IEpic {
		public List<string> dialogs { get; set; }
		public List<string> remarks { get; set; }
		public int countOfEvents { get; }
	}
}