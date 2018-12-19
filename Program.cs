using System;
using System.Collections.Generic;
using System.Linq;

namespace LiteratureAbstraction {
	public class Program {
		static void Main(string[] args) {
			var dramas = new WorkCollection<Drama>();
			for (int i = 0; i < 10; i++) {
				Drama drama = new Drama();
				//drama.author.bday.
				var random = new Random();
				drama.date = DateTime.Now.Add(new TimeSpan(random.Next()));
				dramas.Add(drama);
			}

			dramas.Sort((x, y) => { return x.date > y.date; });
			var selectDramas = dramas.Select(SelectByDate);
			dramas.ChangeAll(x => { x.name = "vasya"; });
			Console.WriteLine(dramas);
			//dramas.Select(x => { x.gameobject})
//			List<Transfrom> transfroms = new List<Transfrom>();
//			List<Position> positions = transfroms.Select(x => x.position).ToList();
//		}
		}

		public static void bla(Drama d) {
			d.name = "vasya";
		}
		public static bool SelectByDate(Drama item) {
			return item.date > DateTime.Now.Add(TimeSpan.FromMinutes(2));
		}
	}
}