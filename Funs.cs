using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_lab_6.Ex1
{
    /// <summary>
    /// Статический класс для метода мяукания одного или нескольких объектов способных мяукать
    /// </summary>
    public static class Funs
    {
        /// <summary>
        /// Метод для последовательного мяуканья одного и более мяукающих объектов
        /// </summary>
        /// <param name="meowables">Мяукающие объекты</param>
        public static void meowCare(params Meowable[] meowables)
        {
            foreach (var meowable in meowables)
            {
                meowable.meow();
            }
        }
    }
}
