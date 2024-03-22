using TestMethods;
using library;

namespace TestMethods;

[TestClass]
public class TestsForHandTools
{
    [TestMethod]
    public void Construct1()
    {
        HandTools Tool = new HandTools();

        Assert.AreEqual(Tool.NameOfTool, "No type");
        Assert.AreEqual(Tool.Material, "NoMaterial");
    }

    [TestMethod]
    public void Construct2()
    {
        HandTools Tool = new HandTools("Пила", "Сталь", 3);

        Assert.AreEqual(Tool.NameOfTool, "Пила");
        Assert.AreEqual(Tool.Material, "Сталь");
    }

    [TestMethod]
    public void Equals()
    {
        HandTools Tool1 = new HandTools("Пила", "Сталь", 3);
        HandTools Tool2 = new HandTools("Пила", "Алюминий", 2);
        Tool2.Material = "Сталь";

        Assert.AreEqual(Tool1.Equals(Tool2), true);
    }

    [TestMethod]
    public void TestToString()
    {
        HandTools Tool = new HandTools("Пила", "Сталь", 3);

        Assert.AreEqual(Tool.ToString(), "ID: 3, название инструмента - Пила, материал - Сталь");
    }
}
