using System.Collections.Generic;

namespace LiteratureAbstraction {
	public enum HistoricalForms {
		Antique,
		Knightly,
		Allegorical,
		RomanMorals,
		Psychological,
		ChineseClassic
	}

	class Novel : Work, IEpic {
		public List<string> dialogs { get; set; }
		public List<string> remarks { get; set; }
		public int countOfEvents { get; }

		public HistoricalForms historicalForm { get; set; }
		public override List<Character> characters { get; set; }
	}
}