using System.Collections.Generic;

namespace Literature {
	interface IEpic {
		// сюжет
		// повествование о событиях

		List<string> dialogs { get; set; }
		List<string> remarks { get; set; }

		int countOfEvents { get; }
	}
}