﻿using System;
using System.Collections.Generic;

namespace LiteratureAbstraction {
	class Tragedy : Work, IDramatic {
		public List<string> actions { get; set; }
		public List<string> dialogs { get; set; }
		public List<string> remarks { get; set; }

		public string conflict { get; set; }
		public Character hero { get; set; }
		public override List<Character> characters { get; set; }

		public Tragedy(Author author, int year, string name) : base(author, year, name) {
		}

		public Tragedy(Author author) : base(author) {
		}
	}
}