using TestMethods;
using library;

namespace TestMethods;

[TestClass]
public class TestsForMeasuringTools
{
    [TestMethod]
    public void Construct1()
    {
        MeasuringTools Tool = new MeasuringTools();

        Assert.AreEqual(Tool.NameOfTool, "No type");
        Assert.AreEqual(Tool.Material, "NoMaterial");
        Assert.AreEqual(Tool.Units, "NoUnits");
        Assert.AreEqual(Tool.Accuracy, 1);
    }

    [TestMethod]
    public void Construct2()
    {
        MeasuringTools Tool = new MeasuringTools("Вольтметр", "Алюминий", "Вольт", 0.3, 3);

        Assert.AreEqual(Tool.NameOfTool, "Вольтметр");
        Assert.AreEqual(Tool.Material, "Алюминий");
        Assert.AreEqual(Tool.Units, "Вольт");
        Assert.AreEqual(Tool.Accuracy, 0, 3);
    }

    [TestMethod]
    public void Equals()
    {
        MeasuringTools Tool1 = new MeasuringTools("Вольтметр", "Алюминий", "Вольт", 0.3, 3);
        MeasuringTools Tool2 = new MeasuringTools("Вольтметр", "Алюминий", "кВА", 0.3, 3);
        Tool2.Units = "Вольт";

        Assert.AreEqual(Tool1.Equals(Tool2), true);
    }

    [TestMethod]
    public void TestToString()
    {
        MeasuringTools Tool = new MeasuringTools("Вольтметр", "Алюминий", "Вольт", 0.3, 3);

        Assert.AreEqual(Tool.ToString(), "ID: 3, название инструмента - Вольтметр, материал - Алюминий, единицы измерения - Вольт, точность - 0,3.");
    }

    [TestMethod]
    public void CorrectAccuracy()
    {
        MeasuringTools Tool = new MeasuringTools("Вольтметр", "Алюминий", "Вольт", -2, 3);


        Assert.AreEqual(Tool.Accuracy, 1);
    }
}
