namespace MoneyExtension.Tests;

[TestClass]
public sealed class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 279.98m;
        var cents = valor.ToCents();

        Assert.AreEqual(27998, cents);
    }
}
