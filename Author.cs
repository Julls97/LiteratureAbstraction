using System.Collections.Generic;

namespace LiteratureAbstraction {
	class Author {
		public string firstName { get; private set; }
		public string lastName { get; private set; }
		public int bday { get; private set; }
		public int deathDay { get; private set; }
		public List<Work> works;
		
		int life {
			get { return deathDay - bday; }
		}
	}
}