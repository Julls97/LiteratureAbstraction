using System.Collections.Generic;

namespace LiteratureAbstraction {
	class Story : Work, IEpic {
		public List<string> dialogs { get; set; }
		public List<string> remarks { get; set; }
		public int countOfEvents { get; }

		public string epilog { get; set; }
		public override List<Character> characters { get; set; }

		public List<Character> Persons {
			set {
				if (value.Count > 3)
					throw new System.ArgumentException("Too many characters! Only less than 3.");
				characters = value;
			}
		}

		public void AddPersons(Character person) {
			if (characters.Count > 3)
				throw new System.ArgumentException("Too many characters yet!");
			characters.Add(person);
		}
	}
}