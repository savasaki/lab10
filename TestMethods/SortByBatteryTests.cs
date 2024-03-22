using TestMethods;
using library;

namespace TestMethods;

[TestClass]
public class SortByBatteryTests
{
    [TestMethod]
    public void ShouldReturnPlusOneIfNull()
    {
        int expected = 1;
        ElectricTools et = null;
        ElectricTools et2 = new ElectricTools();

        SortByBattery sortByBattery = new SortByBattery();

        int result = sortByBattery.Compare(et, et2);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ShouldReturnPlusOneIfNull2()
    {
        int expected = 1;
        ElectricTools et2 = null;
        ElectricTools et = new ElectricTools();

        SortByBattery sortByBattery = new SortByBattery();

        int result = sortByBattery.Compare(et, et2);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ShouldReturnPlusOneIfOneIsNotET()
    {
        int expected = 1;
        ElectricTools et2 = new ElectricTools();
        HandTools et = new HandTools();

        SortByBattery sortByBattery = new SortByBattery();

        int result = sortByBattery.Compare(et, et2);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ShouldReturnPlusOneIfOneIsNotET2()
    {
        int expected = 1;
        ElectricTools et = new ElectricTools();
        HandTools et2 = new HandTools();

        SortByBattery sortByBattery = new SortByBattery();

        int result = sortByBattery.Compare(et, et2);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ShouldReturnMinus()
    {
        int expected = -5;
        ElectricTools et = new ElectricTools("Пила", "Батарея", 30, 80);
        ElectricTools et2 = new ElectricTools("Пила", "Батарея", 25, 80);

        SortByBattery sortByBattery = new SortByBattery();

        int result = sortByBattery.Compare(et, et2);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ShouldReturnMinus2()
    {
        int expected = -5;
        ElectricTools et2 = new ElectricTools("Пила", "Батарея", 15, 80);
        ElectricTools et = new ElectricTools("Пила", "Батарея", 20, 80);

        SortByBattery sortByBattery = new SortByBattery();

        int result = sortByBattery.Compare(et, et2);

        Assert.AreEqual(expected, result);
    }


}
