using System.Collections.Generic;

namespace LiteratureAbstraction {
	public class Author {
		public string firstName { get; private set; }
		public string lastName { get; private set; }
		public int bday { get; private set; }
		public int deathDay { get; private set; }
		public List<Work> works;

		int life {
			get { return deathDay - bday; }
		}

		public Author(string firstName, string lastName, int bday, int deathDay) {
			this.firstName = firstName;
			this.lastName = lastName;
			this.bday = bday;
			this.deathDay = deathDay;
		}

		public Author(List<Work> works, string firstName, string lastName, int bday, int deathDay) {
			this.works = works;
			this.firstName = firstName;
			this.lastName = lastName;
			this.bday = bday;
			this.deathDay = deathDay;
		}
	}
}