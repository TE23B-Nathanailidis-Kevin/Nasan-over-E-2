// string [] sak = ["Glas", "Platta", "Träd", "Fluga", "Fågel"];




// string[] sak = new string [6];
// sak[1] = "Glas";
// sak[2] = "Platta";
// sak[3] = "Träd";
// sak[4] = "Fluga";
// sak[5] = "Fågel";

// for (int i = 0; i < sak.Length; i++)
// {
//     Console.WriteLine( sak[i] ); 
// }

// string [] sak = ["Sandor", "Calin", "Edvin", "Gustav", "Alex-Ovidiu"];


// List<int> nummer = [5, 7, 1, 9, 6];

// string [] nummer = ["1", "2", "3", "4", "5"];

// string[] sak = ["Glas", "Platta", "Träd", "Fluga", "Fågel"];

// string [] namn = ["Sandor", "Calin", "Edvin", "Gustav", "Alex-Ovidiu"];

// for (int i = 0; i < sak.Length; i++)
// {
//     Console.WriteLine( $"{namn[i]} ger {sak[i]} betyget {nummer[i]}"); 
// }

List<string> cities = [];
string exit =  "";
while (exit != "exit")
{
    exit = Console.ReadLine(); 
    if (exit != "exit") cities.Add(exit);
}
for (int repeat = 0; repeat < cities.Count; repeat++)
{
    Console.WriteLine(cities[repeat]);
}


Console.ReadLine();