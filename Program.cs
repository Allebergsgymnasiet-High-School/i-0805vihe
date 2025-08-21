// Console.WriteLine("Wälkommen!\nVad heter du?");

// string namn = Console.ReadLine();

// Console.WriteLine("Hej " + namn);
// Console.WriteLine("Var bor du?");
// string plats = Console.ReadLine();

// Console.WriteLine("Vilken är den bästa färgen?");
// string färgen = Console.ReadLine();

// Console.WriteLine($"Välkommen hit {namn}. Jag ser du bor i {plats}.\n"
// + $"Imorgon kväll tycker jag du ska klä dig i {färgen} färger");

// int tal = 5;
// Console.WriteLine(tal);

// // fel kod
// Console.WriteLine("Hur gammal är du?");
// string tal1 = Console.ReadLine();
// Console.WriteLine("Hur gammal är din hund?");
// string tal2 = Console.ReadLine();

// Console.WriteLine(tal1 + tal2);


// Rätt kod
// Console.WriteLine("Hur gammal är du på riktigt?");
// string inmatning = Console.ReadLine();
// int talKonv = Convert.ToInt32(inmatning);

// if (talKonv > 17)
// {
//     Console.WriteLine("Välkommen till krogen");
// }
// else if (talKonv < 18)
// {
//     Console.WriteLine("Stick här ifrån!!");
// }



// Console.WriteLine("Skriv in ett heltal");
// string inm1 = Console.ReadLine();
// Console.WriteLine("Skriv in ett till heltal");
// string inm2 = Console.ReadLine();

// int tal1 = Convert.ToInt32(inm1);
// int tal2 = Convert.ToInt32(inm2);

// int summa = tal1 + tal2;

// Console.WriteLine($"{tal1} + {tal2} = {summa}");







// Console.WriteLine("Välkommen hit!\n Nu ska vi räkna!\n Skriv in ett heltal");

// string im1 = Console.ReadLine();
// Console.WriteLine("Skriv in ett till heltal");
// string im2 = Console.ReadLine();

// int tal1 = Convert.ToInt32(im1);
// int tal2 = Convert.ToInt32(im2);

// int sum = tal1 + tal2;

// Console.WriteLine($"{tal1} + {tal2} = {sum} ");


// Console.WriteLine("Dags för subtraktion\n Skriv in ännu ett heltal!");
// string im3 = Console.ReadLine();
// Console.WriteLine("Ett till heltal!");
// string im4 = Console.ReadLine();

// int tal3 = Convert.ToInt32(im3);
// int tal4 = Convert.ToInt32(im4);
// int summ = tal3 - tal4;
// Console.WriteLine($"{tal3} - {tal4} = {summ}");



// Console.WriteLine("Nu division!\n Skriv in ännu ett heltal!");
// string im5 = Console.ReadLine();
// Console.WriteLine("Ett till heltal!");
// string im6 = Console.ReadLine();

// int tal5 = Convert.ToInt32(im5);
// int tal6 = Convert.ToInt32(im6);
// int summe = tal5 / tal6;
// Console.WriteLine($"{tal5} / {tal6} = {summe}");


// Console.WriteLine("Wow, dags för multiplikation!\n Skriv in ännu ett heltal!");
// string im7 = Console.ReadLine();
// Console.WriteLine("Ett till heltal!");
// string im8 = Console.ReadLine();

// int tal7 = Convert.ToInt32(im7);
// int tal8 = Convert.ToInt32(im8);
// int summan = tal7 * tal8;
// Console.WriteLine($"{tal7} * {tal8} = {summan}");


// Console.WriteLine("Nu en överraskning!\n Skriv in ännu ett heltal!");
// string im9 = Console.ReadLine();
// Console.WriteLine("Ett till heltal!");
// string im0 = Console.ReadLine();

// int tal9 = Convert.ToInt32(im9);
// int tal0 = Convert.ToInt32(im0);
// int summon = tal9 % tal0;
// Console.WriteLine($"{tal9} % {tal0} = {summon}");

Console.WriteLine("Välkommen hit!\n Nu ska vi räkna!\n Skriv in ett heltal");

string im1 = Console.ReadLine();
Console.WriteLine("Skriv in ett till tal");
string im2 = Console.ReadLine();

// double -> double floating point number
double tal1 = Convert.ToDouble(im1);
double tal2 = Convert.ToDouble(im2);
double sum = tal1 + tal2;
Console.WriteLine($"{tal1} + {tal2} = {sum}");



Console.WriteLine("Nu skriv ett heltal!");
string it1 = Console.ReadLine();
Console.WriteLine("Skriv ett tal nu!");
string it2 = Console.ReadLine();

double ta1 = Convert.ToDouble(it1);
double ta2 = Convert.ToDouble(it2);
double dif = ta1 - ta2;
Console.WriteLine($"{ta1} - {ta2} = {dif}");


Console.WriteLine("Nu skriv ett heltal!");
string ie1 = Console.ReadLine();
Console.WriteLine("Skriv ett tal nu!");
string ie2 = Console.ReadLine();

double ti1 = Convert.ToDouble(ie1);
double ti2 = Convert.ToDouble(ie2);
double pro = ti1 * ti2;
Console.WriteLine($"{ti1} * {ti2} = {pro}");


Console.WriteLine("Nu skriv ett heltal!");
string ib1 = Console.ReadLine();
Console.WriteLine("Skriv ett tal nu!");
string ib2 = Console.ReadLine();

double ts1 = Convert.ToDouble(ib1);
double ts2 = Convert.ToDouble(ib2);
double divv = ts1 / ts2;
Console.WriteLine($"{ts1} / {ts2} = {divv}");