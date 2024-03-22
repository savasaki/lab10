namespace library;

public class idNumber
{
    protected int number;

    public int Number
    {
        get => this.number;
        set
        {
            if (value > 0)
            {
                this.number = value;
            }
            else
            {
                this.number = 0;
            }
        }
    }

    public idNumber()
    {
        this.number = 0;
    }

    public idNumber(int number)
    {
        this.number = number;
    }

    public override string ToString()
    {
        return number.ToString();
    }

    public override bool Equals(object? obj)
    {
        if (obj is idNumber n)
            return this.number == n.number;
        return false;
    }
}

public class Tools : IInit, IComparable, ICloneable
{
    protected Random rnd = new Random();

    public idNumber id;

    protected string[] nameOfElectricTools = { "Аккумуляторный шуруповёрт", "Ленточная пила", "Сабельная пила", "Торцовочная пила с горизонтальным перемещением" };
    protected string[] nameOfHandTools = { "Универсальный нож", "Молоток-гвоздодёр", "Алмазное точило", "Набор шестигранников" };
    protected string[] nameOfMeasuringTools = { "Анемометр", "Вольтметр", "Дозиметр", "Измеритель мощности" };
    protected string[] nameOfTools = { "Аккумуляторный шуруповёрт", "Ленточная пила", "Сабельная пила", "Торцовочная пила с горизонтальным перемещением", "Универсальный нож", "Молоток-гвоздодёр", "Алмазное точило", "Набор шестигранников", "Анемометр", "Вольтметр", "Дозиметр", "Измеритель мощности" };

    public string NameOfTool { get; set; }

    public Tools()
    {
        NameOfTool = "No type";
        id = new idNumber(0);
    }

    public Tools(string Name, int number)
    {
        NameOfTool = Name;
        id = new idNumber(number);
    }

    public override bool Equals(object obj)
    {
        Tools instrument = obj as Tools;
        if (instrument != null)
            return instrument.NameOfTool == this.NameOfTool;
        else
            return false;
    }

    public override string ToString()
    {
        return $"ID: {this.id}, название инструмента - {NameOfTool}";
    }

    public virtual void Init()
    {
        Console.Write("Введите ID: ");
        try
        {
            id = new idNumber(Int32.Parse(Console.ReadLine()));
        }
        catch
        {
            id = new idNumber(0);
        }
        Console.WriteLine("Введите название инструмента");
        NameOfTool = Console.ReadLine();
    }

    public virtual void RandomInit()
    {
        NameOfTool = nameOfTools[rnd.Next(nameOfTools.Length)];
        id = new idNumber(rnd.Next(1, 1000));
    }

    public virtual void Show()
    {
        Console.WriteLine($"ID {this.id}: Название - {NameOfTool}");
    }

    public int CompareTo(object? obj)
    {
        if (obj == null) return -1;
        if (obj is not Tools) return -1;
        Tools instrument = obj as Tools;
        return string.Compare(this.NameOfTool, instrument.NameOfTool);
    }

    public object Clone()
    {
        return new Tools(NameOfTool, id.Number);
    }

    public object ShallowCopy()
    {
        return this.MemberwiseClone();
    }
}

