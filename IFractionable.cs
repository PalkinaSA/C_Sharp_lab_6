using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_lab_6.Ex2
{
    /// <summary>
    /// Интерфейс для работы с дробью: вычисления её вещественного значения, установки значения числителя и знаменателя
    /// </summary>
    public interface IFractionable
    {
        /// <summary>
        /// Основа для метода получения вещественного значения дроби
        /// </summary>
        /// <returns>Дробь в вещественном виде</returns>
        public double GetDoubleValue();

        /// <summary>
        /// Основа для метода установки значения числителя
        /// </summary>
        /// <param name="number">Целочисленное значение для числителя</param>
        public void SetNumerator(int number);

        /// <summary>
        /// Основа для метода установки значения знаменателя
        /// </summary>
        /// <param name="number">Целочисленное значение для знаменателя</param>
        public void SetDenominator(int number);
    }
}

