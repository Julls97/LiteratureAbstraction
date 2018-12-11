using System.Collections.Generic;

namespace LiteratureAbstraction {
	interface IDramatic {
		// диалоги, реплики
		// действия
		// театральность, ремарки

		List<string> actions { get; set; }
		List<string> dialogs { get; set; }
		List<string> remarks { get; set; }

		int countOfCharacters { get; }
		int countOfActions { get; }
		int countOfDialogs { get; }
		int countOfRemarks { get; }
	}
}