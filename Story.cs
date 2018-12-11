using System.Collections.Generic;

namespace Literature {
	class Story : IEpic {
		public List<string> dialogs { get; set; }
		public List<string> remarks { get; set; }
		public int countOfEvents { get; }
	}
}