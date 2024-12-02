namespace AdventOfCode2024.Tests;

[TestClass]
public sealed class Day01Tests
{
    [TestMethod]
    public void TestDay1Part1()
    {
        Assert.AreEqual(Day01.Day01.Part1(), 1189304);
    }

    [TestMethod]
    public void TestDay1Part2()
    {
        Assert.AreEqual(Day01.Day01.Part2(), 24349736);
    }
}
