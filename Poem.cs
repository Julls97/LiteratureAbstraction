using System;
using System.Collections.Generic;

namespace LiteratureAbstraction {
	public enum PoemTypes {
		didactic,
		satirical,
		burlesque,
		romantic,
		lyricDramatic
	}

	class Poem : Work, IEpic, ILyric {
		public List<string> dialogs { get; set; }
		public List<string> remarks { get; set; }
		public int countOfEvents { get; }
		public string sizeOfVerse { get; set; }
		public string rhyme { get; set; }
		public override List<Character> characters { get; set; }
		public PoemTypes poemType { get; set; }


		public Poem(Author author, DateTime year, string name) : base(author, year, name) {}
		public Poem(Author author) : base(author) {}

		public override string GetDescription() {
			string s = "Дорогой читатель! Ты держишь в руках книгу " + name + ", которую написал " +
			           author.firstName + " " + author.lastName +
			           ". Это произведение было написано в " + Year +
			           " году. В этой книге основным является ";

			string s1 = "лиpичecкий гepoй – этo oбpaз пoэтa (eгo лиpичecкoe Я), " +
			            "чьи пepeживaния, мыcли и чyвcтвa oтpaжeны в лиpичecкoм пpoизвeдeнии. " +
			            "Лиpичecкий гepoй нe тoждecтвeн биoгpaфичecкoй личнocти. " +
			            "Пpeдcтaвлeниe o гepoe лиpичecкoм нocит cyммapный xapaктep и фopмиpyeтcя " +
			            "в пpoцecce пpиoбщeния к тoмy внyтpeннeмy миpy, кoтopый pacкpывaeтcя " +
			            "в лиpичecкиx пpoизвeдeнияx нe чepeз пocтyпки, a чepeз пepeживaния, " +
			            "дyшeвныe cocтoяния, мaнepy peчeвoгo caмoвыpaжeния.";

			return s + s1;
		}
	}
}