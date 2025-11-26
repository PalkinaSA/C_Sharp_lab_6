using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_lab_6.Ex2
{
    /// <summary>
    /// Класс для кэширования дроби
    /// </summary>
    public class CachedFraction : IFractionable
    {
        private double? _cachedDecimalValue = null;
        private Fraction _fraction;

        /// <summary>
        /// Создание кэшированной дроби
        /// </summary>
        /// <param name="fraction">Дробь для кэширования</param>
        public CachedFraction(Fraction fraction)
        {
            _fraction = fraction;
            _cachedDecimalValue = fraction.GetDecimalValue();
        }

        /// <summary>
        /// Метод получения вещественного значения дроби
        /// </summary>
        /// <returns>Вещественное значение дроби</returns>
        public double GetDecimalValue()
        {
            if (_cachedDecimalValue == null)
            {
                _cachedDecimalValue = _fraction.GetDecimalValue();
            }
            return _cachedDecimalValue.Value;
        }

        /// <summary>
        /// Метод установки значения числителя
        /// </summary>
        /// <param name="number">Целочисленное значение для числителя</param>
        public void SetNumerator(int number)
        {
            _fraction.SetNumerator(number);
            _cachedDecimalValue = null;
        }

        /// <summary>
        /// Метод установки значения знаменателя
        /// </summary>
        /// <param name="number">Целочисленное значение для знаменателя</param>
        public void SetDenominator(int number) 
        { 
            _fraction.SetDenominator(number);
            _cachedDecimalValue = null;
        }

        /// <summary>
        /// Переопределённый метод, возвращающий кэшированную дробь в виде строки
        /// </summary>
        /// <returns>Строка вида "Числитель/Знаменатель"</returns>
        public override string ToString() 
        {
            return _fraction.ToString();
        }
    }
}
