using System;
namespace library
{
    public class ElectricTools : Tools
    {

        static string[] typeOfPowerSourse = { "Питание от розетки", "Батарея", "Ручная сила" };
        public string PowerSource { get; set; }

        protected int batterylife;
        public int BatteryLife
        {
            get => batterylife;
            set
            {
                if (PowerSource != "Батарея")
                    batterylife = 0;
                else
                    batterylife = value;
            }
        }


        public ElectricTools() : base()
        {
            PowerSource = "NoBattery";
            BatteryLife = 0;
        }

        public ElectricTools(string name, string powersource, int batterylife, int id) : base(name, id)
        {
            PowerSource = powersource;
            BatteryLife = batterylife;
        }

        public override bool Equals(object obj)
        {
            ElectricTools instrument = obj as ElectricTools;
            if (instrument != null)
                return instrument.NameOfTool == this.NameOfTool && instrument.PowerSource == this.PowerSource && instrument.BatteryLife == this.BatteryLife;
            else
                return false;
        }

        public override string ToString()
        {
            return base.ToString() + $", источник питания - {PowerSource}, время работы от батареи в минутах - {BatteryLife}";
        }

        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите источник питания, благодаря которому работает инструмент.");
            PowerSource = Console.ReadLine();
            try
            {
                BatteryLife = int.Parse(Console.ReadLine());
            }
            catch
            {
                BatteryLife = 0;
            }
        }

        public override void RandomInit()
        {
            do
            {
                base.RandomInit();
                if (Array.Exists(nameOfElectricTools, element => element == NameOfTool))
                {
                    PowerSource = typeOfPowerSourse[rnd.Next(typeOfPowerSourse.Length)];
                    BatteryLife = rnd.Next(30, 120);
                }
            } while (PowerSource == "NoBattery");
        }

        public override void Show()
        {
            Console.WriteLine($"ID {this.id}: Наименование - {NameOfTool}, источник питания - {PowerSource}, время работы от батареи в минутах - {BatteryLife}");
        }
    }
}
