using System;
namespace library
{
    public class HandTools : Tools
    {

        static string[] typeOfMaterial = { "Сталь", "Алюминий", "Древесина", "Пластик", "Углеродное волокно" };
        public string Material { get; set; }

        public HandTools() : base()
        {
            Material = "NoMaterial";
        }

        public HandTools(string name, string material, int id) : base(name, id)
        {
            Material = material;
        }

        public override bool Equals(object obj)
        {
            HandTools instrument = obj as HandTools;
            if (instrument != null)
                return instrument.NameOfTool == this.NameOfTool && instrument.Material == this.Material;
            else
                return false;
        }

        public override string ToString()
        {
            return base.ToString() + $", материал - {Material}";
        }

        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите название материала, из которого сделан инструмент.");
            Material = Console.ReadLine();
        }

        public override void RandomInit()
        {
            do
            {
                base.RandomInit();
                if (Array.Exists(nameOfHandTools, element => element == NameOfTool))
                {
                    Material = typeOfMaterial[rnd.Next(typeOfMaterial.Length)];
                }
            } while (Material == "NoMaterial");
        }

        public override void Show()
        {
            Console.WriteLine($"ID {this.id}: название - {NameOfTool}, материал - {Material}");
        }

    }
}