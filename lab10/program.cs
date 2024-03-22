using program;
using library;

static void SearchWoodenInstruments(IInit[] array, double InputAccuracy)
{
    foreach (IInit item in array)
    {
        if (item is MeasuringTools instrument && instrument.Material == "Древесина" && InputAccuracy > instrument.Accuracy)
        {
            Console.WriteLine($"Названия деревянных измерительных инструментов, точность которых выше заданной: {instrument.NameOfTool}");
        }
    }
}

static void AverageAccuracy(IInit[] array)
{
    double sum = 0;
    int count = 0;
    foreach (IInit item in array)
    {
        if (item is MeasuringTools instrument)
        {
            sum += instrument.Accuracy;
            count++;
        }
    }
    Console.WriteLine($"Средняя точность измерительных инструментов: {sum / count}");
}

static void MaxBatteryLife(IInit[] array)
{
    int maxBatteryLife = 0;
    foreach (IInit item in array)
    {
        if (item is ElectricTools instrument && instrument.BatteryLife > maxBatteryLife)
        {
            maxBatteryLife = instrument.BatteryLife;
        }
    }
    if (maxBatteryLife == 0)
        Console.WriteLine("Электрических инструментов с аккумуляторами нет");
    else
        Console.WriteLine($"Максимальное время работы аккумуляторного электрического инструмента: {maxBatteryLife}");
}

IInit[] array = new IInit[28];
int action;

do
{
    action = InterFace.ChooseAction();
    switch (action)
    {
        case 1:
            Console.Clear();
            for (int i = 0; i <= 6; i++)
            {
                Tools temp = new Tools();
                temp.RandomInit();
                array[i] = temp;
            }
            for (int i = 7; i <= 13; i++)
            {
                HandTools temp = new HandTools();
                temp.RandomInit();
                array[i] = temp;
            }
            for (int i = 14; i <= 20; i++)
            {
                ElectricTools temp = new ElectricTools();
                temp.RandomInit();
                array[i] = temp;
            }
            for (int i = 21; i <= 27; i++)
            {
                MeasuringTools temp = new MeasuringTools();
                temp.RandomInit();
                array[i] = temp;
            }
            break;
        case 2:
            Console.Clear();
            foreach (Tools i in array)
            {
                i.Show();
            }
            break;
        case 3:
            Console.Clear();
            SearchWoodenInstruments(array, 0.9);
            break;
        case 4:
            Console.Clear();
            AverageAccuracy(array);
            break;
        case 5:
            Console.Clear();
            MaxBatteryLife(array);
            break;
        case 6:
            Console.Clear();
            Array.Sort(array);
            Console.WriteLine("Массив отсортирован по названию инструмента");
            break;
        case 7:
            Console.Clear();
            int CountOfEl = 0;
            foreach (IInit item in array)
            {
                if (item is ElectricTools)
                    CountOfEl++;
            }
            ElectricTools[] ArrOfElectricTools = new ElectricTools[CountOfEl];

            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] is ElectricTools electricTool)
                {
                    ArrOfElectricTools[j] = electricTool;
                    j++;
                }
            }

            Array.Sort(ArrOfElectricTools, new SortByBattery());
            foreach (ElectricTools item in ArrOfElectricTools)
            {
                Console.WriteLine(item.ToString());
            }
            break;
        case 8:
            Console.Clear();
            Tools required1 = new Tools("Ножницы", 585);
            array[0] = required1;
            Array.Sort(array);
            int index1 = Array.BinarySearch(array, new Tools("Ножницы", 585));
            Console.WriteLine($"Искомый элемент расположен на {index1 + 1} позиции");
            break;
        case 9:
            Console.Clear();
            Tools watch = new Tools();
            watch.RandomInit();
            Console.WriteLine(watch);
            Tools copyWatch = (Tools)watch.ShallowCopy();
            Console.WriteLine(copyWatch);
            Tools cloneWatch = (Tools)watch.Clone();
            Console.WriteLine(cloneWatch);

            Console.WriteLine("Меняем данные для демонстрации разницы:");
            copyWatch.NameOfTool = "Копия: " + watch.NameOfTool;
            copyWatch.id.Number = 5;
            cloneWatch.NameOfTool = "Клон: " + watch.NameOfTool;
            cloneWatch.id.Number = 10;
            Console.WriteLine(watch);
            Console.WriteLine(copyWatch);
            Console.WriteLine(cloneWatch);
            break;
        case 0:
            break;
    }
} while (action != 0);