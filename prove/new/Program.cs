// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Team awesomesauce = new Team("Awesome Sauce", 0, 0);

Player neymar = new Player("Neymar jr.", 10, "Forward");
Player Kobe = new Player("Kobe Bryant", 24);


Kobe.SetPosition("Point Guard");


awesomesauce.AddPlayer(Kobe);
awesomesauce.AddPlayer(neymar);

awesomesauce.AddWin();
awesomesauce.AddLoss();

awesomesauce.DisplayRoster();

