using NUnit.Framework;
using Altom.AltDriver;
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;
using System.Linq;

// Class that constructs the basic x and y layouts for defining postional variables for the Menu Buttons
public class OptionsIconConstructor {
    public float x { get; set; }
    public float y { get; set; }
}

public class OptionsandEconomyTests
{   //Important! If your test file is inside a folder that contains an .asmdef file, please make sure that the assembly definition references NUnit.
    public AltDriver altDriver;
    //Before any test it connects with the socket
    [OneTimeSetUp]
    public void SetUp()
    {
        altDriver =new AltDriver();
    }

    //At the end of the test closes the connection with the socket
    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

// ===================== Buy Economy Items ===================

    [Test]
    public void BuyTheCoinsUI()
    {
        var CoinShopIcon = new OptionsIconConstructor { x = 736f, y = 370f };
        var ShopScreenObject = altDriver.WaitForObject(By.NAME, "ShopScreen");
        const string StringNameToCompare = "ShopScreen";

        altDriver.MoveMouse(new AltVector2(CoinShopIcon.x, CoinShopIcon.y), 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
        Debug.Log("Action 1: Clicked The Coin shop Icon!");

        // verify we are on the shop screen
        if (ShopScreenObject.name == "ShopScreen")
        {
            Assert.AreEqual(ShopScreenObject.name, StringNameToCompare);
            Debug.Log("Action 2: Assertion that popup screen is: " + ShopScreenObject.name);
        }
        else
        {
            Debug.Log("End result is not expected ");
            Assert.Fail();
        }
    }

    [Test]
    public void BuyTheDiamondsUI()
    {
        var DiamondShopIcon = new OptionsIconConstructor { x = 840f, y = 370f };
        altDriver.MoveMouse(new AltVector2(DiamondShopIcon.x, DiamondShopIcon.y), 1);
        altDriver.PressKey(AltKeyCode.Mouse0, 0.1f);
        Debug.Log("Action 1: Clicked the Diamond shop Icon!");

        // verify we are on the shop screen
        //ShopScreen
    }
}