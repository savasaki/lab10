using TestMethods;
using library;

namespace TestMethods;

[TestClass]
public class TestsForTools
{
    [TestMethod]
    public void Construct1()
    {
        Tools Tool = new Tools();

        Assert.AreEqual(Tool.NameOfTool, "No type");
    }

    [TestMethod]
    public void Construct2()
    {
        Tools Tool = new Tools("Пила", 3);

        Assert.AreEqual(Tool.NameOfTool, "Пила");
    }

    [TestMethod]
    public void Equals()
    {
        Tools Tool1 = new Tools("Пила", 3);
        Tools Tool2 = new Tools("Дрель", 2);
        Tool2.NameOfTool = "Пила";

        Assert.AreEqual(Tool1.Equals(Tool2), true);
    }

    [TestMethod]
    public void TestToString()
    {
        Tools Tool = new Tools("Пила", 3);

        Assert.AreEqual(Tool.ToString(), "ID: 3, название инструмента - Пила");
    }

    [TestMethod]
    public void TestClone()
    {
        Tools Tool = new Tools("Пила", 3);
        Tools ToolClone = (Tools)Tool.Clone();


        Assert.AreEqual(Tool.ToString(), ToolClone.ToString());
    }

    [TestMethod]
    public void TestCopy()
    {
        Tools Tool = new Tools("Пила", 3);
        Tools ToolClone = (Tools)Tool.ShallowCopy();


        Assert.AreEqual(Tool.ToString(), ToolClone.ToString());
    }


}
