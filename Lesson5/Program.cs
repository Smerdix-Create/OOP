using Lesson5;

var a = new RationalNumbers(3, 5);
var b = new RationalNumbers(3, 5);
/*
Console.WriteLine(a != b);
Console.WriteLine(a <= b);

b++;
Console.WriteLine($"{b.Numerator}, {b.Denominator}");
Console.WriteLine();*/

Console.WriteLine(a.ToString());

if (a.Denominator == 0 || b.Denominator == 0)
{
    Console.WriteLine("Знаменатель не может быть нулем");
    return;
}

var c = a / b;
c.GetAbbreviatedNumber();

Console.WriteLine(c.Numerator);
Console.WriteLine("-");
Console.WriteLine(c.Denominator);

Console.ReadKey();
