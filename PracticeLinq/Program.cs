List<string> videoGames = new List<string>() { "Starcraft", "Warcraft", "MarioParty", "Zelda", "Sonic_The_Hedgehog" };

videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));


