using TestMethods;
using library;

namespace TestMethods;

[TestClass]
public class TestsForElectricTools
{
    [TestMethod]
    public void Construct1()
    {
        ElectricTools Tool = new ElectricTools();

        Assert.AreEqual(Tool.NameOfTool, "No type");
        Assert.AreEqual(Tool.PowerSource, "NoBattery");
        Assert.AreEqual(Tool.BatteryLife, 0);
    }

    [TestMethod]
    public void Construct2()
    {
        ElectricTools Tool = new ElectricTools("Ленточная пила", "Батарея", 60, 3);

        Assert.AreEqual(Tool.NameOfTool, "Ленточная пила");
        Assert.AreEqual(Tool.PowerSource, "Батарея");
        Assert.AreEqual(Tool.BatteryLife, 60);
    }

    [TestMethod]
    public void Equals()
    {
        ElectricTools Tool1 = new ElectricTools("Ленточная пила", "Батарея", 60, 3);
        ElectricTools Tool2 = new ElectricTools("Ленточная пила", "Батарея", 50, 3);
        Tool2.BatteryLife = 60;

        Assert.AreEqual(Tool1.Equals(Tool2), true);
    }

    [TestMethod]
    public void TestToString()
    {
        ElectricTools Tool = new ElectricTools("Ленточная пила", "Батарея", 60, 3);

        Assert.AreEqual(Tool.ToString(), "ID: 3, название инструмента - Ленточная пила, источник питания - Батарея, время работы от батареи в минутах - 60");
    }

    [TestMethod]
    public void HaveABattery()
    {
        ElectricTools Tool = new ElectricTools("Ленточная пила", "Ручная сила", 60, 1);


        Assert.AreEqual(Tool.BatteryLife, 0);
    }
}
