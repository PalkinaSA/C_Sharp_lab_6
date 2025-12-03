using C_Sharp_lab_6.Ex1;
using C_Sharp_lab_6.Ex2;
using System.Linq.Expressions;

namespace C_Sharp_lab_6
{
    /// <summary>
    /// Класс самой программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Метод для начала выполнения программы
        /// </summary>
        public static void Main() 
        {
            Ex1();
            Console.WriteLine();
            Ex2();
        }

        /// <summary>
        /// Метод для выполнения задания 1 с котами
        /// </summary>
        private static void Ex1()
        {
            // 1.1 Кот мяукает
            Cat barsik = new Cat("Барсик");
            barsik.meow();
            barsik.meow(3);
            Console.WriteLine();

            // 1.2. Интерфейс мяуканье
            Meowable m = barsik;
            Meowable r = new Cat("Рыжик");
            Meowable g = new Cat("Говер");

            Funs.meowCare(m, r, g);
            Meowable electroCat1 = new ElectroCat("Электро1", "M19287");
            Meowable electroCat2 = new ElectroCat("Электро2", "Desiel 3");
            Funs.meowCare(electroCat1, electroCat2);
            Console.WriteLine();

            // 1.3. Количество мяуканий
            MeowCounter meowCounter = new MeowCounter(m);
            Funs.meowCare(meowCounter);
            Funs.meowCare(2, meowCounter);
            Console.WriteLine(meowCounter);
        }

        /// <summary>
        /// Метод для выполнения задания 2 с дробями
        /// </summary>
        private static void Ex2()
        {
            // Создаём дроби и используем их в арифметических опперациях
            Fraction f1 = new Fraction(1, 4);
            Fraction f2 = new Fraction(-1, 5);
            Fraction f3 = new Fraction(10, 6);

            Console.WriteLine("Результаты вычислений:");
            Console.WriteLine($"{f1} + {f2} = {f1.sum(f2)}");
            Console.WriteLine($"{f1} + 5 = {f1.sum(5)}");
            Console.WriteLine($"{f1} - {f3} = {f1.minus(f3)}");
            Console.WriteLine($"{f1} - 5 = {f1.minus(5)}");
            Console.WriteLine($"{f1} / {f2} = {f1.div(f2)}");
            Console.WriteLine($"{f1} / -3 = {f1.div(-3)}");
            Console.WriteLine($"{f1} * {f3} = {f1.mult(f3)}");
            Console.WriteLine($"{f1} * -4 = {f1.mult(-4)}");
            Console.WriteLine();

            Console.WriteLine("Результат вычисления выражения:");
            Console.WriteLine($"(({f1} + {f2}) / {f3}) - 5 = {f1.sum(f2).div(f3).minus(5)}");
            Console.WriteLine();

            // Сравниваем дроби
            Console.WriteLine($"Равны ли дробь {f2} и {f3}? {f2.Equals(f1)}");
            Console.WriteLine($"Равны ли дробь {f2} и дробь -1/5? {f2.Equals(new Fraction(-1, 5))}");
            Console.WriteLine($"Равны ли дробь {f3} и дробь {3.5}? {f2.Equals(3.5)}");
            Console.WriteLine();

            // Клонирование дроби
            Fraction f1clone = (Fraction)f1.Clone();
            Console.WriteLine($"Создали клона {f1} = {f1clone}");
            Console.WriteLine();

            // Интерфейсы и кэширование
            Fraction f4 = new Fraction(-5, -4);
            Console.WriteLine($"До изменения значений дроби {f4} : {f4.GetDoubleValue()}");
            f4.SetDenominator(5);
            f4.SetNumerator(-4);
            Console.WriteLine($"После изменения значений дроби {f4} : {f4.GetDoubleValue()}");

            CachedFraction cachedFraction = new CachedFraction(f4);
            Console.WriteLine($"Кэширование дроби {f4} : {cachedFraction.GetDoubleValue()}");
            cachedFraction.SetDenominator(-5);
            cachedFraction.SetNumerator(4);
            Console.WriteLine($"Кэширование дроби {f4} после изменения параментров дроби : " +
                cachedFraction.GetDoubleValue());
        }
    }

}


