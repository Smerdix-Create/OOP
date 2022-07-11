using Lesson5;

var a = new RationalNumbers(-4, 7);
var b = new RationalNumbers(5, 8);

var c = a + b;


/*
 https://tutomath.ru/6-klass/slozhenie-racionalnyx-chisel-pravila-i-primery.html
https://ru.wikipedia.org/wiki/%D0%A0%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%B0%D0%BB%D1%8C%D0%BD%D0%BE%D0%B5_%D1%87%D0%B8%D1%81%D0%BB%D0%BE
 */

Console.WriteLine(c.Numerator);
Console.WriteLine("-");
Console.WriteLine(c.Denominator);

Console.ReadKey();
