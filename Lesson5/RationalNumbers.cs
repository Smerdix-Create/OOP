namespace Lesson5
{
    class RationalNumbers
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public RationalNumbers (int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static RationalNumbers operator +(RationalNumbers a, RationalNumbers b)
        {
            if (a.Denominator == b.Denominator)
            {
                return new RationalNumbers((a.Numerator + b.Numerator) /a.Denominator, a.Numerator);
            }
            else
            {
                return new RationalNumbers((a.Numerator * b.Denominator + b.Numerator * a.Denominator), (a.Denominator * b.Denominator));
            }
        }

    }
}

