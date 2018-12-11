using System.Collections.Generic;

namespace Literature {
	interface IDramatic {
		// диалоги, реплики
		// действия
		// театральность, ремарки

		List<string> characters { get; set; }
		List<string> actions { get; set; }
		List<string> dialogs { get; set; }
		List<string> remarks { get; set; }

		int countOfCharacters { get; }
		int countOfActions { get; }
		int countOfDialogs { get; }
		int countOfRemarks { get; }
	}
}