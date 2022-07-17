namespace Lesson5
{
    class RationalNumbers
    {
        /// <summary>
        /// Числитель
        /// </summary>
        public int Numerator { get; private set; }
        /// <summary>
        /// Знаменатель
        /// </summary>
        public int Denominator { get; private set; }

        public RationalNumbers (int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        /// <summary>
        /// Вычисление суммы
        /// </summary>
        /// <param name="a">Первая дробь</param>
        /// <param name="b">Вторая дробь</param>
        /// <returns></returns>
        public static RationalNumbers operator +(RationalNumbers a, RationalNumbers b)
        {
            if (a.Denominator == b.Denominator)
            {
                return new RationalNumbers(a.Numerator + b.Numerator, a.Denominator);
            }
            else
            {
                return new RationalNumbers(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);
            }
        }

        /// <summary>
        /// Вычисление разности
        /// </summary>
        /// <param name="a">Первая дробь</param>
        /// <param name="b">Вторая дробь</param>
        /// <returns></returns>
        public static RationalNumbers operator -(RationalNumbers a, RationalNumbers b)
        {
            if (a.Denominator == b.Denominator)
            {

                return new RationalNumbers(a.Numerator - b.Numerator, a.Denominator);
            }
            else
            {
                return new RationalNumbers(a.Numerator * b.Denominator - b.Numerator * a.Denominator, a.Denominator * b.Denominator);
            }
        }

        /// <summary>
        /// Вычисление произведения
        /// </summary>
        /// <param name="a">Первая дробь</param>
        /// <param name="b">Вторая дробь</param>
        /// <returns></returns>
        public static RationalNumbers operator *(RationalNumbers a, RationalNumbers b)
        {
            return new RationalNumbers(a.Numerator * b.Numerator, a.Denominator * b.Denominator); 
        }


        /// <summary>
        /// Вычисление частного
        /// </summary>
        /// <param name="a">Первая дробь</param>
        /// <param name="b">Вторая дробь</param>
        /// <returns></returns>
        public static RationalNumbers operator /(RationalNumbers a, RationalNumbers b)
        {
            return new RationalNumbers(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }

        /// <summary>
        /// Инкрементация дроби
        /// </summary>
        /// <param name="a">Дробь</param>
        /// <returns></returns>
        public static RationalNumbers operator ++(RationalNumbers a)
        {
            a.Numerator++;
            a.Denominator++;
            return a;
        }

        /// <summary>
        /// Декрементация дроби
        /// </summary>
        /// <param name="a">Дробь</param>
        /// <returns></returns>
        public static RationalNumbers operator --(RationalNumbers a)
        {
            a.Numerator--;
            a.Denominator--;
            return a;
        }

        /// <summary>
        /// Проверка равенства дроби по полям
        /// </summary>
        /// <param name="a">Первая дробь</param>
        /// <param name="b">Вторая дробь</param>
        /// <returns></returns>
        public static bool operator ==(RationalNumbers a, RationalNumbers b)
        {
            return (a.Numerator == b.Numerator && a.Denominator == b.Denominator);
        }

        /// <summary>
        /// Проверка неравенства дроби по полям
        /// </summary>
        /// <param name="a">Первая дробь</param>
        /// <param name="b">Вторая дробь</param>
        /// <returns></returns>
        public static bool operator !=(RationalNumbers a, RationalNumbers b)
        {
            return (a.Numerator != b.Numerator || a.Denominator != b.Denominator);
        }

        /// <summary>
        /// Переопределение Equals
        /// </summary>
        /// <param name="obj">Дробь</param>
        /// <returns></returns>
        public override bool Equals(Object? obj)
        {
            if (obj is RationalNumbers bankAccount) return Numerator == bankAccount.Numerator && Denominator == bankAccount.Denominator;
            return false;
        }

        /// <summary>
        /// Переопределение GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return (123 * Numerator.GetHashCode()) ^ Denominator.GetHashCode();
            }
        }


        /// <summary>
        /// Сравнение дробей. Больше
        /// </summary>
        /// <param name="a">Первая дробь</param>
        /// <param name="b">Вторая дробь</param>
        /// <returns></returns>
        public static bool operator >(RationalNumbers a, RationalNumbers b)
        {
            if (a.Denominator == b.Denominator)
            {

                return (a.Numerator > b.Numerator);
            }
            else
            {
                return (a.Denominator * b.Denominator / a.Denominator * a.Numerator > a.Denominator * b.Denominator / b.Denominator * b.Numerator);
            }
        }

        /// <summary>
        /// Сравнение дробей. Меньше
        /// </summary>
        /// <param name="a">Первая дробь</param>
        /// <param name="b">Вторая дробь</param>
        /// <returns></returns>
        public static bool operator <(RationalNumbers a, RationalNumbers b)
        {
            if (a.Denominator == b.Denominator)
            {

                return (a.Numerator < b.Numerator);
            }
            else
            {
                return (a.Denominator * b.Denominator / a.Denominator * a.Numerator < a.Denominator * b.Denominator / b.Denominator * b.Numerator);
            }
        }

        /// <summary>
        /// Сравнение дробей. Больше или равно
        /// </summary>
        /// <param name="a">Первая дробь</param>
        /// <param name="b">Вторая дробь</param>
        /// <returns></returns>
        public static bool operator >=(RationalNumbers a, RationalNumbers b)
        {
            if (a.Denominator == b.Denominator)
            {

                return (a.Numerator >= b.Numerator);
            }
            else
            {
                return (a.Denominator * b.Denominator / a.Denominator * a.Numerator >= a.Denominator * b.Denominator / b.Denominator * b.Numerator);
            }
        }

        /// <summary>
        /// Сравнение дробей. Меньше или равно
        /// </summary>
        /// <param name="a">Первая дробь</param>
        /// <param name="b">Вторая дробь</param>
        /// <returns></returns>
        public static bool operator <=(RationalNumbers a, RationalNumbers b)
        {
            if (a.Denominator == b.Denominator)
            {

                return (a.Numerator <= b.Numerator);
            }
            else
            {
                return (a.Denominator * b.Denominator / a.Denominator * a.Numerator <= a.Denominator * b.Denominator / b.Denominator * b.Numerator);
            }
        }

        /// <summary>
        /// Вычисление остатка от деления
        /// </summary>
        /// <param name="a">Первая дробь</param>
        /// <param name="b">Вторая дробь</param>
        /// <returns></returns>
        public static double operator %(RationalNumbers a, RationalNumbers b)
        {
            int z = a.Numerator * b.Denominator;
            int x = a.Denominator * b.Numerator;

            return z - (z / x) * x;
        }

        /// <summary>
        /// Получение строкового формата
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Числитель {Numerator}, Знаменатель {Denominator}";

        /// <summary>
        /// Получение сокращенной дроби
        /// </summary>
        public void GetAbbreviatedNumber()
        {
            for (int i = 2; i < this.Denominator; i++)
            {
                if (this.Numerator % i == 0 && this.Denominator % i == 0)
                {
                    this.Numerator = this.Numerator / i;
                    this.Denominator = this.Denominator / i;
                    i--;
                }
            }
            return;
        }

    }
}

