using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_lab_6.Ex1
{
    /// <summary>
    /// Класс, представляющий собой кота со способностью мяукать
    /// </summary>
    public class Cat : Meowable
    {
        private string _name;

        /// <summary>
        /// Свойство - имя кота
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
        /// Создание кота с помощью его имени
        /// </summary>
        /// <param name="name">Имя кота</param>
        public Cat(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Этот метод выводит в консоль мяуканье кота
        /// </summary>
        public void meow()
        {
            Console.WriteLine($"{Name}: мяу!");
        }

        /// <summary>
        /// Этот метод выводит в консоль мяу от кота определённое количество раз
        /// </summary>
        /// <param name="times">Сколько раз мяукнуть коту</param>
        public void meow(int times)
        {
            if (times <= 0)
            {
                Console.WriteLine("Нельзя мяукать неположительное число раз");
                return;
            }

            Console.Write($"{Name}: ");
            for (int i = 0; i < times - 1; i++)
            {
                Console.Write("мяу-");
            }
            Console.WriteLine("мяу!");
        }

        /// <summary>
        /// Метод, возвращающий строку типа "кот: Имя_кота".
        /// </summary>
        /// <returns>
        /// Строка с данными об коте
        /// </returns>
        public override string ToString()
        {
            return $"кот: {Name}";
        }
    }
}

