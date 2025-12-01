using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_lab_6.Ex1
{
    /// <summary>
    /// Класс для подсчёта мяуканья
    /// </summary>
    public class MeowCounter : Meowable
    {
        private readonly Meowable _meowable;
        private int _meowCount;

        /// <summary>
        /// Счётчик мяуканий для переданного объекта способного мяукать
        /// </summary>
        public int MeowCount
        {
            get
            {
                return _meowCount;
            }
            set
            {
                if (value >= 0) 
                { 
                    _meowCount = value;
                }
            }
        }

        /// <summary>
        /// Создание счётчика мяуканий для объекта способного мяукать
        /// </summary>
        /// <param name="meowable">Объект способный мяукать</param>
        public MeowCounter(Meowable meowable)
        {
            _meowable = meowable;
            MeowCount = 0;
        }

        /// <summary>
        /// Метод для мяуканий и подсчёта мяуканий
        /// </summary>
        public void meow()
        {
            _meowable.meow();
            MeowCount++;
        }

        /// <summary>
        /// Метод для мяуканий определённое количество раз и подсчёта этих мяуканий
        /// </summary>
        /// <param name="times">Сколько раз мяукнуть</param>
        public void meow(int times)
        {
            if (times <= 0)
            {
                Console.WriteLine("Нельзя мяукать неположительное количество раз");
                return;
            }
            _meowable.meow(times);
            MeowCount += times;
        }

        /// <summary>
        /// Метод получения корректной формы слова "разы"
        /// </summary>
        /// <returns>Строка вида "раз" или "раза"</returns>
        private string GetCorrectTimesForm()
        {
            int lastDigit = _meowCount % 10;
            int lastTwoDigits = _meowCount % 100;

            if (lastTwoDigits >= 11 && lastTwoDigits <= 14)
            {
                return "раз";
            }

            switch (lastDigit)
            {
                case 2 or 3 or 4: return "раза";
                default: return "раз";
            }
        }
        
        /// <summary>
        /// Метод, возвращающий строку вида "Данные_о_мяукающем_объекте мяукает Количество_раз раз"
        /// </summary>
        /// <returns>Строка с данными о мяукающем объекте и его количестве мяуканий</returns>
        public override string ToString()
        {
            return _meowable.ToString() + $" мяукнул {MeowCount} " + GetCorrectTimesForm();
        }
    }
}



