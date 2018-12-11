using System.Collections.Generic;

namespace LiteratureAbstraction {
	abstract class Work {
			public Author author { get; private set; }
			public string date { get; private set; }
			public string name { get; private set; }
			public string genre { get; private set; }
			public string kind { get; private set; }
			List<Character> characters { get; set; }
		}
}

