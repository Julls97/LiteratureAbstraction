using System;

namespace LiteratureAbstraction {
	public class Program {
		static void Main(string[] args) {
			var dramas = new WorkCollection<Drama>();
			for (int i = 0; i < 10; i++) {
				Drama drama = new Drama();
				var random = new Random();
				drama.date = DateTime.Now.Add(new TimeSpan(random.Next()));
				dramas.Add(drama);
			}

			dramas.Sort((x, y) => { return x.date.CompareTo(y.date) == -1; });
			Console.WriteLine(dramas);
		}
	}
}