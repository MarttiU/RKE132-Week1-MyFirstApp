//See on kommentaar mu koodile
//Rakendus küsib kasutajalt sisestada tema nime
//Rakendus tervitab nimepidi

Console.WriteLine("Sisesta oma nimi");
//string - sõne (jah sõne)
string userName;
userName = Console.ReadLine();
Console.WriteLine("Tere" + ", " + userName + "!");

//string interpolation

Console.WriteLine($"Hello {userName}!");
