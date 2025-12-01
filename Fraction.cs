using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_lab_6.Ex2
{
    /// <summary>
    /// Класс, представляющий собой дробь
    /// </summary>
    public class Fraction : ICloneable, IFractionable
    {
        private int _numerator;
        private int _denominator;

        /// <summary>
        /// Свойство - числитель (целое число)
        /// </summary>
        public int Numerator
        {
            get
            {
                return _numerator; 
            }
            set
            {
                _numerator = value;
            }
        }

        /// <summary>
        /// Свойство - знаменатель (целое число)
        /// </summary>
        public int Denominator
        {
            get
            {
                return _denominator;
            }
            set
            {
                if (value > 0)
                {
                    _denominator = value;
                }
                else if (value < 0)
                {
                    _numerator = -_numerator;
                    _denominator = -value;
                }
                else
                {
                    Console.WriteLine("Нельзя делить на 0");
                    _numerator = 0;
                    _denominator = 1;
                }
            }
        }

        /// <summary>
        /// Создание дроби с помощью числителя и знаменателя
        /// </summary>
        /// <param name="numerator">Значение числителя (целое число)</param>
        /// <param name="denominator">Значение знаменателя (целое число)</param>
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            Reduce();
        }

        /// <summary>
        /// Операция сложения дробей
        /// </summary>
        /// <param name="fraction1">Первая дробь</param>
        /// <param name="fraction2">Вторая дробь</param>
        /// <returns>Новая дробь - результат сложения дроби1 и дроби2</returns>
        public static Fraction operator +(Fraction fraction1, Fraction fraction2) 
        {
            return new Fraction(fraction1.Numerator * fraction2.Denominator + fraction2.Numerator
                * fraction1.Denominator, fraction1.Denominator * fraction2.Denominator);
        }

        /// <summary>
        /// Операция сложения дроби и целого числа
        /// </summary>
        /// <param name="fraction">Дробь</param>
        /// <param name="number">Целое число</param>
        /// <returns>Новая дробь - результат сложения дроби и целого числа</returns>
        public static Fraction operator +(Fraction fraction, int number)
        {
            return fraction + new Fraction(number, 1);
        }

        /// <summary>
        /// Операция сложения целого числа и дроби
        /// </summary>
        /// <param name="number">Целое число</param>
        /// <param name="fraction">Дробь</param>
        /// <returns>Новая дробь - результат сложения целого числа и дроби</returns>
        public static Fraction operator +(int number, Fraction fraction)
        {
            return new Fraction(number, 1) + fraction;
        }

        /// <summary>
        /// Операция вычитания дробей
        /// </summary>
        /// <param name="fraction1">Первая дробь</param>
        /// <param name="fraction2">Вторая дробь</param>
        /// <returns>Новая дробь - результат вычитания дроби2 из дроби1</returns>
        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            return new Fraction(fraction1.Numerator * fraction2.Denominator - fraction2.Numerator
                * fraction1.Denominator, fraction1.Denominator * fraction2.Denominator);
        }

        /// <summary>
        /// Операция вычитания из дроби целого числа
        /// </summary>
        /// <param name="fraction">Дробь</param>
        /// <param name="number">Целое число</param>
        /// <returns>Новая дробь - результат вычитания из дроби целого числа</returns>
        public static Fraction operator -(Fraction fraction, int number)
        {
            return fraction - new Fraction(number, 1);
        }

        /// <summary>
        /// Операция вычитания из целого числа дроби
        /// </summary>
        /// <param name="fraction">Дробь</param>
        /// <param name="number">Целое число</param>
        /// <returns>Новая дробь - результат вычитания из целого числа дроби</returns>
        public static Fraction operator -(int number, Fraction fraction)
        {
            return new Fraction(number, 1) - fraction;
        }

        /// <summary>
        /// Операция умножения дробей
        /// </summary>
        /// <param name="fraction1">Первая дробь</param>
        /// <param name="fraction2">Вторая дробь</param>
        /// <returns>Новая дробь - результат умножения дроби1 на дробь2</returns>
        public static Fraction operator *(Fraction fraction1, Fraction fraction2) 
        {
            return new Fraction(fraction1.Numerator * fraction2.Numerator, 
                fraction1.Denominator * fraction2.Denominator);
        }

        /// <summary>
        /// Операция умножения дроби на целое число
        /// </summary>
        /// <param name="fraction">Дробь</param>
        /// <param name="number">Целое число</param>
        /// <returns>Новая дробь - результат умножения дроби на целое число</returns>
        public static Fraction operator *(Fraction fraction, int number)
        {
            return fraction * new Fraction(number, 1);
        }

        /// <summary>
        /// Операция умножения целого числа на дробь
        /// </summary>
        /// <param name="fraction">Дробь</param>
        /// <param name="number">Целое число</param>
        /// <returns>Новая дробь - результат умножения дроби на целое число</returns>
        public static Fraction operator *(int number, Fraction fraction)
        {
            return fraction * new Fraction(number, 1);
        }

        /// <summary>
        /// Операция деления дробей
        /// </summary>
        /// <param name="fraction1">Первая дробь</param>
        /// <param name="fraction2">Вторая дробь</param>
        /// <returns>Новая дробь - результат деления дроби1 на дробь2</returns>
        public static Fraction operator /(Fraction fraction1, Fraction fraction2) 
        {
            return new Fraction(fraction1.Numerator * fraction2.Denominator, 
                fraction1.Denominator * fraction2.Numerator);
        }

        /// <summary>
        /// Операция деления дроби на целое число
        /// </summary>
        /// <param name="fraction">Дробь</param>
        /// <param name="number">Целое число</param>
        /// <returns>Новая дробь - результат деления дроби на целое число</returns>
        public static Fraction operator /(Fraction fraction, int number)
        {
            return fraction / new Fraction(number, 1);
        }

        /// <summary>
        /// Операция деления целого числа на дробь
        /// </summary>
        /// <param name="fraction">Дробь</param>
        /// <param name="number">Целое число</param>
        /// <returns>Новая дробь - результат деления целого числа на дробь</returns>
        public static Fraction operator /(int number, Fraction fraction)
        {
            return new Fraction(number, 1) / fraction;
        }

        /// <summary>
        /// Метод поиска наибольшего общего делителя для двух чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns>Наибольший общий делитель чисел a и b</returns>
        private static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GCD(b, a % b);
            }
        }

        /// <summary>
        /// Метод для сокращения дроби
        /// </summary>
        private void Reduce()
        {
            int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
            Numerator /= gcd;
            Denominator /= gcd;
        }

        /// <summary>
        /// Сложение двух дробей
        /// </summary>
        /// <param name="fraction">Дробь, с которой складываем</param>
        /// <returns>Дробь - результат сложения дробей</returns>
        public Fraction sum(Fraction fraction)
        {
            return this + fraction;
        }

        /// <summary>
        /// Вычитание двух дробей
        /// </summary>
        /// <param name="fraction">Дробь, которую вычитаем</param>
        /// <returns>Дробь - результат вычитания дробей</returns>
        public Fraction minus(Fraction fraction)
        {
            return this - fraction; 
        }

        /// <summary>
        /// Деление на дробь
        /// </summary>
        /// <param name="fraction">Дробь, на которую делим</param>
        /// <returns>Дробь - результат деления дробей</returns>
        public Fraction div(Fraction fraction)
        {
            return this / fraction;
        }

        /// <summary>
        /// Умножение двух дробей
        /// </summary>
        /// <param name="fraction">Дробь,на которую умножаем</param>
        /// <returns>Дробь - результат умножения дробей</returns>
        public Fraction mult(Fraction fraction)
        {
            return this * fraction;
        }

        /// <summary>
        /// Сложение дроби с целым числом
        /// </summary>
        /// <param name="number">Целое число, с которым складываем</param>
        /// <returns>Дробь - результат сложения дроби и целого числа</returns>
        public Fraction sum(int number)
        {
            return this + number;
        }

        /// <summary>
        /// Вычитание из дроби целого числа
        /// </summary>
        /// <param name="number">Целое число, которое вычитаем</param>
        /// <returns>Дробь - результат вычитания из дроби целого числа</returns>
        public Fraction minus(int number)
        {
            return this - number;
        }

        /// <summary>
        /// Деление дроби на целое число
        /// </summary>
        /// <param name="number">Целое число, на которое делим</param>
        /// <returns>Дробь - результат деления дроби на целое число</returns>
        public Fraction div(int number)
        {
            return this / number;
        }

        /// <summary>
        /// Умножение дроби на целое число
        /// </summary>
        /// <param name="number">Целое число, на которое умножаем</param>
        /// <returns>Дробь - результат умножения дроби на целое число</returns>
        public Fraction mult(int number)
        {
            return this * number;
        }

        /// <summary>
        /// Метод, создающий глубокую копию оригинальной дроби
        /// </summary>
        /// <returns>Полная копия исходной дроби класса дроби</returns>
        public object Clone()
        {
            return new Fraction(Numerator, Denominator);
        }

        /// <summary>
        /// Метод получения вещественного значения дроби
        /// </summary>
        /// <returns>Дробь в вещественном виде</returns>
        public double GetDoubleValue()
        {
            return (double)Numerator / Denominator;
        }

        /// <summary>
        /// Метод для установки значения числителя
        /// </summary>
        /// <param name="number">Целочисленное значение для числителя</param>
        public void SetNumerator(int number)
        {
            Numerator = number;
        }

        /// <summary>
        /// Метод для установки значения знаменателя
        /// </summary>
        /// <param name="number">Целочисленное значение для знаменателя</param>
        public void SetDenominator(int number)
        {
            Denominator = number;
        }

        /// <summary>
        /// Переопределённый метод, возвращающий строку вида "Числитель/Знаменатель"
        /// </summary>
        /// <returns>Дробь в строковом представлении</returns>
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        /// <summary>
        /// Переопределённый метод, сравнивающий дробь с объектом, потенциально являющимся дробью, по их числителю и знаменателю
        /// </summary>
        /// <param name="obj">Объект для сравнения</param>
        /// <returns>Логический результат сравнивания числителя и знаменателя</returns>
        public override bool Equals(object? obj)
        {
            return obj is Fraction other && Numerator == other.Numerator && Denominator == other.Denominator;
        }

        /// <summary>
        /// Переопределённый метод предоставвления хэш-кода дроби
        /// </summary>
        /// <returns>Целое число - хэш-код на основе значения числителя и знаменателя</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }
    }
}

