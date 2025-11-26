using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_lab_6.Ex1
{
    /// <summary>
    /// Интерфейс, придающий способность мяукать
    /// </summary>
    public interface Meowable
    {
        /// <summary>
        /// Основа метода для мяуканья
        /// </summary>
        public void meow();

        /// <summary>
        /// Основа метода для мяуканья определённого количества раз
        /// </summary>
        /// <param name="times">Сколько раз мяукнуть</param>
        public void meow(int times);
    }
}
