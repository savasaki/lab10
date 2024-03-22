using System;
namespace program
{
    public class InterFace
    {
        public static int CheckInput(int from, int to, string startmessage)
        {
            string input;
            int output;
            bool isCorrect;
            do
            {
                Console.WriteLine(startmessage);
                input = Console.ReadLine();
                isCorrect = Int32.TryParse(input, out output);
                isCorrect = isCorrect && output >= from && output <= to;
                if (!isCorrect)
                {
                    Console.WriteLine("\nВы ввели неподходящее число, повторите ввод!\n");
                }
            } while (!isCorrect);
            Console.WriteLine();
            return output;
        }

        public static int ChooseAction()
        {
            int numberOfAction;
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Сформировать массив");
            Console.WriteLine("2. Распечатать массив");
            Console.WriteLine("3. Названия деревянных измерительных инструментов, точность которых выше заданной");
            Console.WriteLine("4. Средняя точность измерительных инструментов");
            Console.WriteLine("5. Максимальное время работы аккумуляторного электрического инструмента");
            Console.WriteLine("6. Сортировка массива по названию");
            Console.WriteLine("7. Сортировка массива по времени работы аккумулятора");
            Console.WriteLine("8. Бинарный поиск в массиве, отсортированном по бренду");
            Console.WriteLine("9. Демонстрационный вариант с копирование значений и ссылок");
            Console.WriteLine("0. Завершить");
            numberOfAction = CheckInput(0, 9, "Выберите номер меню");
            Console.Clear();
            Console.WriteLine($"Выбрано действие: {numberOfAction}");
            return numberOfAction;
        }
    }

}