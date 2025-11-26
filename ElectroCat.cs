using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_lab_6.Ex1
{
    /// <summary>
    /// Класс, представляющий собой электро-кота со способностью мяукать
    /// </summary>
    public class ElectroCat : Meowable
    {
        private string _name;
        private string _engineModel;

        /// <summary>
        /// Свойство - имя электро-кота
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Свойство - название двигателя
        /// </summary>
        public string EngineModel
        {
            get
            {
                return _engineModel; 
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _engineModel = value;
                }
            }
        }

        /// <summary>
        /// Создание электро-кота с помощью его имени и названия двигателя
        /// </summary>
        /// <param name="name">Имя электро-кота</param>
        /// <param name="engineModel">Название двигателя электро-кота</param>
        public ElectroCat(string name, string engineModel)
        {
            Name = name;
            EngineModel = engineModel;
        }

        /// <summary>
        /// Этот метод выводит в консоль мяу от электро-кота
        /// </summary>
        public void meow()
        {
            Console.WriteLine($"{Name}: бип-бип мяу! Мой двигатель {EngineModel} требует топливо в виде рыбки!");
        }

        /// <summary>
        /// Этот метод выводит в консоль мяу от электро-кота определённое количество раз
        /// </summary>
        /// <param name="times">Сколько раз мяукнуть электро-коту</param>
        public void meow(int times)
        {
            if (times < 0)
            {
                Console.WriteLine("Нельзя мяукать отрицательное число раз");
                return;
            }

            for (int i = 0; i < times; i++)
            {
                meow();
            }
        }

        /// <summary>
        /// Метод, возвращающий строку типа "Электро-кот: Имя_электро-кота, Название_двигателя_электро-кота".
        /// </summary>
        /// <returns>
        /// Строка с данными об электро-коте
        /// </returns>
        public override string ToString()
        {
            return $"Электро-кот: {Name}, {EngineModel}";
        }
    }
}