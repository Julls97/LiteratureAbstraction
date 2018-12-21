using System;
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


		public Novel(Author author, DateTime year, string name) : base(author, year, name) {}
		public Novel(Author author) : base(author) {}
		
		public override string GetDescription() {
			string s =  "Дорогой читатель! Ты держишь в руках книгу " + name + ", которую написал " +
			            author.firstName + " " + author.lastName +
			            ". Это произведение было написано в " + year.Year +
			            " году. Жанр этой книги ";

			string s1 = "рoмaн – этo эпичecкoe пoвecтвoвaниe c элeмeнтaми диaлoгa, " +
			            "инoгдa и c включeниeм дpaмы или литepaтypныx oтcтyплeний, " +
			            "cocpeдoтoчeннoe нa иcтopии oтдeльнoй личнocти в oбщecтвeннoй cpeдe. " +
			            "Главная личность в этой книге - " + characters[0].name;

			return s + s1;
		}
	}
}