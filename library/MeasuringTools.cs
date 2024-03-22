using System;
namespace library
{
    public class MeasuringTools : Tools
    {

        static string[] TypeOfMaterial = { "Сталь", "Алюминий", "Древесина", "Пластик", "Углеродное волокно" };
        public string Material { get; set; }

        static string[] TypeOfUnits = { "м/с", "Вольт", "Беккерель", "кВА" };
        public string Units { get; set; }

        protected double accuracy;
        public double Accuracy
        {
            get => accuracy;
            set
            {
                if (value <= 0)
                    accuracy = 1.0;
                else
                    accuracy = value;
            }
        }

        public MeasuringTools() : base()
        {
            Material = "NoMaterial";
            Units = "NoUnits";
            Accuracy = 1;
        }

        public MeasuringTools(string name, string material, string units, double accuracy, int id) : base(name, id)
        {
            Material = material;
            Units = units;
            Accuracy = accuracy;
        }

        public override bool Equals(object obj)
        {
            MeasuringTools instrument = obj as MeasuringTools;
            if (instrument != null)
                return instrument.NameOfTool == this.NameOfTool && instrument.Material == this.Material && instrument.Units == this.Units && instrument.Accuracy == this.Accuracy;
            else
                return false;
        }

        public override string ToString()
        {
            return base.ToString() + $", материал - {Material}, единицы измерения - {Units}, точность - {Accuracy}.";
        }

        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите название материала, из которого сделан инструмент.");
            Material = Console.ReadLine();
            Console.WriteLine("Введите единицы измерения");
            Units = Console.ReadLine();
            try
            {
                Console.WriteLine("Введите точность измерения прибора");
                Accuracy = double.Parse(Console.ReadLine());
            }
            catch
            {
                Accuracy = 1.0;
            }
        }

        public override void RandomInit()
        {
            do
            {
                base.RandomInit();
                if (Array.Exists(nameOfMeasuringTools, element => element == NameOfTool))
                {
                    Material = TypeOfMaterial[rnd.Next(TypeOfMaterial.Length)];
                    Units = TypeOfUnits[rnd.Next(TypeOfUnits.Length)];
                    Accuracy = rnd.NextDouble();
                }
            } while (Units == "NoUnits");
        }

        public override void Show()
        {
            Console.WriteLine($"ID {this.id}: Название - {NameOfTool}, материал - {Material}, единицы измерения - {Units}, точность - {Accuracy}.");
        }
    }
}

