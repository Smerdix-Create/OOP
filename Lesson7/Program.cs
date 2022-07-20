using Lesson7;

string word = "Однозначно, явные признаки победы институционализации заблокированы в рамках своих собственных рациональных ограничений.";

string pit = "Валерий";

var acoderA = new ACoder(word);
var acoderB = new BCoder(pit);

Console.WriteLine(acoderA.Encode());
Console.WriteLine();
Console.WriteLine(acoderA.Encode());
Console.WriteLine();
Console.WriteLine(acoderA.Decode());
Console.WriteLine();
Console.WriteLine(acoderA.Decode());
Console.WriteLine();
Console.WriteLine(acoderB.Encode());
Console.WriteLine();
Console.WriteLine(acoderB.Decode());

Console.ReadKey();