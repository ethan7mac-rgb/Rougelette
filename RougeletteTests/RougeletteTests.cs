namespace RougeletteTests;

using Rougelette;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

[TestClass]
public sealed class RougeletteFormTests
{
    [TestMethod]
    public void ItemShop_GoldSet()
    {
        // Arrange
        frmItemShop shop = new frmItemShop(150);

        // Act
        int expected = 150;
        int actual = shop.gold;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ItemShop_ListEmpty()
    {
        // Arrange
        frmItemShop shop = new frmItemShop(150);

        // Act
        int expected = 0;
        int actual = shop.ShoppingList.Count;

        // Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ItemShop_NegativeGold()
    {
        // Arrange
        frmItemShop shop = new frmItemShop(-50);

        // Act
        int expected = -50;
        int actual = shop.gold;

        // Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Monkey_NameSet()
    {
        // Arrange
        Monkey monkey = new Monkey();

        // Act
        string actual = monkey.Name;

        // Assert
        Assert.AreEqual("Monkey", actual);
    }
    [TestMethod]
    public void Cowboy_StartingMoneySet()
    {
        // Arrange
        Cowboy cowboy = new Cowboy();

        // Act
        int actual = cowboy.StartingMoney;

        // Assert
        Assert.AreEqual(6, actual);
    }
    [TestMethod]
    public void ExtraMoney_NameSet()
    {
        // Arrange
        ExtraMoney item = new ExtraMoney();

        // Act
        string actual = item.Name;

        // Assert
        Assert.AreEqual("Extra Return from Number", actual);
    }
    [TestMethod]
    public void ExtraMoney_PriceSet()
    {
        // Arrange
        ExtraMoney item = new ExtraMoney();

        // Act
        int actual = item.Price;

        // Assert
        Assert.AreEqual(10, actual);
    }
    [TestMethod]
    public void ExtraLife_NameSet()
    {
        // Arrange
        ExtraLife life = new ExtraLife();

        // Act
        string actual = life.Name;

        // Assert
        Assert.AreEqual("Extra Chance to Roll", actual);
    }
    [TestMethod]
    public void Chris_NameSet()
    {
        // Arrange
        Chris chris = new Chris();

        // Act
        string actual = chris.Name;

        // Assert
        Assert.AreEqual("Chris London", actual);
    }
    [TestMethod]
    public void ItemHelper_DurCheckPositive()
    {
        // Arrange
        int dur = 3;

        // Act
        bool actual = ItemHelper.DurCheck(dur);

        // Assert
        Assert.IsFalse(actual);
    }
}