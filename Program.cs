using System;
using System.Collections.Generic;

namespace LiteratureAbstraction {
	public class Program {
		static void Main(string[] args) {
			Author Shakespeare = new Author("Уильям", "Шекспир", 1564, 1616);
			Author Ostrovsky = new Author("Александр", "Островский", 1823, 1886);
			Author Lermontov = new Author("Михаил", "Лермонтов", 1823, 1886);
			Author Pushkin = new Author("Александр", "Пушкин", 1799, 1837);
			Author Zhukovsky = new Author("Василий", "Жуковский", 1783, 1852);
			Author Dostoevsky = new Author("Фёдор Михайлович", "Достоевский", 1821, 1881);		

			Work RomeoAndJuliet = new Tragedy(Shakespeare, 1595, "Ромео и Джульетта");
			Work TheTamingOfTheShrew = new Comedy(Shakespeare, 1593, "Укрощение строптивой");
			Work Thunderstorm = new Drama(Ostrovsky, 1859, "Гроза");			
			Work AHeroOfOurTime = new Novel(Lermontov, 1840, "Герой нашего времени");			
			Work PoorFolk = new Novel(Dostoevsky, 1846, "Бедные люди"); // Devushkin Dobroselova Mr. Bykov
			Work Demons = new Novel(Dostoevsky, 1871, "Бесы"); // Verkhovensky Stavrogina  Stavrogin Shatov Kirillov
			Work TheBrothersKaramazov  = new Novel(Dostoevsky, 1880, "Братья Карамазовы "); // Fyodor Karamazov // Dmitri Fyodorovich Karamazov // Ivan Fyodorovich Karamazov // Alexei Fyodorovich Karamazov 
			Work TheIdiot  = new Novel(Dostoevsky, 1869, "Идиот"); // Prince Myshkin Nastasya Filippovna Rogózhin Ippolít Teréntyev 
			Work CrimeAndPunishment = new Novel(Dostoevsky, 1866, "Преступление и наказание"); // Raskolnikov (Rodion) // Sofya Semyonovna Marmeladova // Razumikhin Svidrigaïlov
			Work Borodino = new Poem(Lermontov, 1837, "Бородино");
			Work TheQueenOfSpades = new Story(Pushkin, 1833, "Пиковая дама");
			Work Monument = new Ode(Pushkin, 1836, "Я памятник себе воздвиг нерукотворный");
			Work Elegy = new Elegy(Pushkin, 1830, "Безумных лет угасшее веселье");
			Work Svetlana = new Ballad(Zhukovsky, 1813, "Раз в крещенский вечерок Девушки гадали");

			Character Raskolnikov = new Character("Родион Раскольников");
			CrimeAndPunishment.characters = new List<Character>() {Raskolnikov};
			
			Character Romeo = new Character();
			Character Juliet = new Character();
			RomeoAndJuliet.characters = new List<Character>() {Romeo, Juliet};

			Character Katarina = new Character();
			Character Petruchio = new Character();
			TheTamingOfTheShrew.characters = new List<Character>() {Katarina, Petruchio};

			var works = new WorkCollection<Work>();
			works.Add(RomeoAndJuliet);
			works.Add(TheTamingOfTheShrew);
			works.Add(Thunderstorm);
			works.Add(AHeroOfOurTime);
			works.Add(PoorFolk);
			works.Add(Demons);
			works.Add(TheBrothersKaramazov);
			works.Add(TheIdiot);
			works.Add(CrimeAndPunishment);
			works.Add(Borodino);
			works.Add(TheQueenOfSpades);
			works.Add(Monument);
			works.Add(Elegy);
			works.Add(Svetlana);

			Console.WriteLine(CrimeAndPunishment.GetDescription());
			Console.WriteLine(Borodino.GetDescription());
			
			works.Sort((x, y) => { return x.date > y.date; });
			var selectNovel = works.Select(SelectNovel);
			foreach (var item in selectNovel) {
				Console.WriteLine(item.name);
			}
			works.ChangeAll(x => { x.date = x.date; });
		}

		public static bool SelectByDate(Drama item) {
			return item.date > DateTime.Now.Add(TimeSpan.FromMinutes(2));
		}
		
		public static bool SelectNovel(Work item) {
			return item is Novel;
		}
	}
}