namespace LiteratureAbstraction {
	public class Character {
		public string name;
		public string biography;
		public string description;

		public Character(string name, string biography, string description) {
			this.name = name;
			this.biography = biography;
			this.description = description;
		}

		public Character(string name) {
			this.name = name;
		}

		public Character() {
		}
	}
}