using System.Collections.Generic;

namespace LiteratureAbstraction {
	class Drama : Work, IDramatic {
		public List<string> actions { get; set; }
		public List<string> dialogs { get; set; }
		public List<string> remarks { get; set; }
		public int countOfCharacters { get; }
		public int countOfActions { get; }
		public int countOfDialogs { get; }
		public int countOfRemarks { get; }
	}
}