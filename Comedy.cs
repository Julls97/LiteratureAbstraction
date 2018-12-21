﻿using System;
using System.Collections.Generic;

namespace LiteratureAbstraction {
	public enum ComedyType {
		Satiric,
		Humoric
	}

	class Comedy : Work, IDramatic {
		public List<string> actions { get; set; }
		public List<string> dialogs { get; set; }
		public List<string> remarks { get; set; }

		public ComedyType comedyTypes { get; set; }
		public List<string> jokes { get; set; }
		public override List<Character> characters { get; set; }

		public Comedy(Author author, DateTime date, string name, string kind) : base(author, date, name, kind) {
		}

		public Comedy(Author author) : base(author) {
		}
	}
}