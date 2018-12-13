using System.Collections.Generic;

namespace LiteratureAbstraction {
	public enum OdaTypes { //  В литературе различают оды хвалебные, праздничные, плачевные.
		Laudatory,
		Festive,
		Deplorable
	}

	class Ode : Work, ILyric {
		public string sizeOfVerse { get; set; }
		public string rhyme { get; set; }
		public override List<Character> characters { get; set; }
		public OdaTypes odaType { get; set; }
		
		// Введение рассуждение заключение
		public string Introduction { get; set; }
		public string Reasoning { get; set; }
		public string Conclusion { get; set; }
	}
}